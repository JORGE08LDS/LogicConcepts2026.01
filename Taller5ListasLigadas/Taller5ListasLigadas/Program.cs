using System;

class Program
{
    static void Main(string[] args)
    {
        ListaDoble<string> lista = new ListaDoble<string>();

        int opcion;
        string dato;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Adicionar");
            Console.WriteLine("2. Mostrar hacia adelante");
            Console.WriteLine("3. Mostrar hacia atras");
            Console.WriteLine("4. Ordenar descendentemente");
            Console.WriteLine("5. Mostrar modas");
            Console.WriteLine("6. Mostrar grafico");
            Console.WriteLine("7. Existe");
            Console.WriteLine("8. Eliminar una ocurrencia");
            Console.WriteLine("9. Eliminar todas las ocurrencias");
            Console.WriteLine("0. Salir");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese dato:");
                    dato = Console.ReadLine();
                    lista.Adicionar(dato);
                    break;

                case 2:
                    lista.MostrarAdelante();
                    break;

                case 3:
                    lista.MostrarAtras();
                    break;

                case 4:
                    lista.OrdenarDescendente();
                    Console.WriteLine("Lista ordenada");
                    break;

                case 5:
                    lista.MostrarModas();
                    break;

                case 6:
                    lista.MostrarGrafico();
                    break;

                case 7:
                    Console.WriteLine("Ingrese dato:");
                    dato = Console.ReadLine();

                    if (lista.Existe(dato))
                        Console.WriteLine("Si existe");
                    else
                        Console.WriteLine("No existe");

                    break;

                case 8:
                    Console.WriteLine("Dato a eliminar:");
                    dato = Console.ReadLine();
                    lista.EliminarUna(dato);
                    break;

                case 9:
                    Console.WriteLine("Dato a eliminar:");
                    dato = Console.ReadLine();
                    lista.EliminarTodas(dato);
                    break;
                case 0:
                    Console.WriteLine("Fin");
                    break;
            }

        } while (opcion != 0);
    }
}