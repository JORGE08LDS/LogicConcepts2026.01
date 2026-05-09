using System;
using System.Collections.Generic;

public class ListaDoble<T> where T : IComparable<T>
{
    private Nodo<T> cabeza;
    private Nodo<T> cola;

    public ListaDoble()
    {
        cabeza = null;
        cola = null;
    }

    public void Adicionar(T dato)
    {
        Nodo<T> nuevo = new Nodo<T>(dato);

        if (cabeza == null)
        {
            cabeza = nuevo;
            cola = nuevo;
            return;
        }

        if (dato.CompareTo(cabeza.Dato) <= 0)
        {
            nuevo.Siguiente = cabeza;
            cabeza.Anterior = nuevo;
            cabeza = nuevo;
            return;
        }

        Nodo<T> actual = cabeza;

        while (actual.Siguiente != null &&
               dato.CompareTo(actual.Siguiente.Dato) > 0)
        {
            actual = actual.Siguiente;
        }

        nuevo.Siguiente = actual.Siguiente;
        nuevo.Anterior = actual;

        if (actual.Siguiente != null)
        {
            actual.Siguiente.Anterior = nuevo;
        }
        else
        {
            cola = nuevo;
        }

        actual.Siguiente = nuevo;
    }

    public void MostrarAdelante()
    {
        Nodo<T> actual = cabeza;

        while (actual != null)
        {
            Console.WriteLine(actual.Dato);
            actual = actual.Siguiente;
        }
    }

    public void MostrarAtras()
    {
        Nodo<T> actual = cola;

        while (actual != null)
        {
            Console.WriteLine(actual.Dato);
            actual = actual.Anterior;
        }
    }

    public void OrdenarDescendente()
    {
        Nodo<T> actual = cabeza;

        while (actual != null)
        {
            Nodo<T> siguiente = actual.Siguiente;

            while (siguiente != null)
            {
                if (actual.Dato.CompareTo(siguiente.Dato) < 0)
                {
                    T temporal = actual.Dato;
                    actual.Dato = siguiente.Dato;
                    siguiente.Dato = temporal;
                }

                siguiente = siguiente.Siguiente;
            }

            actual = actual.Siguiente;
        }
    }

    public bool Existe(T dato)
    {
        Nodo<T> actual = cabeza;

        while (actual != null)
        {
            if (actual.Dato.Equals(dato))
                return true;

            actual = actual.Siguiente;
        }

        return false;
    }
    public void MostrarModas()
    {
        Dictionary<T, int> conteo = new Dictionary<T, int>();

        Nodo<T> actual = cabeza;

        while (actual != null)
        {
            if (conteo.ContainsKey(actual.Dato))
                conteo[actual.Dato]++;
            else
                conteo[actual.Dato] = 1;

            actual = actual.Siguiente;
        }

        int mayor = 0;

        foreach (var item in conteo)
        {
            if (item.Value > mayor)
                mayor = item.Value;
        }

        Console.WriteLine("Moda(s):");

        foreach (var item in conteo)
        {
            if (item.Value == mayor)
            {
                Console.WriteLine(item.Key + " aparece " + mayor + " veces");
            }
        }
    }

    public void MostrarGrafico()
    {
        Dictionary<T, int> conteo = new Dictionary<T, int>();

        Nodo<T> actual = cabeza;

        while (actual != null)
        {
            if (conteo.ContainsKey(actual.Dato))
                conteo[actual.Dato]++;
            else
                conteo[actual.Dato] = 1;

            actual = actual.Siguiente;
        }

        foreach (var item in conteo)
        {
            Console.Write(item.Key + " ");

            for (int i = 0; i < item.Value; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }

    public void EliminarUna(T dato)
    {
        Nodo<T> actual = cabeza;

        while (actual != null)
        {
            if (actual.Dato.Equals(dato))
            {
                if (actual == cabeza)
                {
                    cabeza = cabeza.Siguiente;

                    if (cabeza != null)
                        cabeza.Anterior = null;
                }
                else
                {
                    actual.Anterior.Siguiente = actual.Siguiente;
                }

                if (actual == cola)
                {
                    cola = actual.Anterior;
                }
                else
                {
                    if (actual.Siguiente != null)
                        actual.Siguiente.Anterior = actual.Anterior;
                }

                Console.WriteLine("Elemento eliminado");
                return;
            }

            actual = actual.Siguiente;
        }

        Console.WriteLine("Elemento no encontrado");
    }

    public void EliminarTodas(T dato)
    {
        while (Existe(dato))
        {
            EliminarUna(dato);
        }
    }
}