using System;
using System.Collections.Generic;

class CosechandoCaballo
{
    static void Main()
    {
        Console.Write("Ingrese ubicación de los frutos: ");
        string entrada = Console.ReadLine()!;

        Console.Write("Ingrese posición inicial del caballo: ");
        string inicio = Console.ReadLine()!;

        Console.Write("Ingrese los movimientos del caballo: ");
        string movs = Console.ReadLine()!;

        Dictionary<string, char> frutos = new Dictionary<string, char>();

        string[] datos = entrada.Split(',');

        foreach (string d in datos)
        {
            string pos = d.Substring(0, 2);
            char fruto = d[2];
            frutos[pos] = fruto;
        }

        int col = inicio[0] - 'A';
        int fila = int.Parse(inicio[1].ToString());

        string[] movimientos = movs.Split(',');

        List<char> recogidos = new List<char>();

        foreach (string m in movimientos)
        {
            switch (m)
            {
                case "UL": col -= 1; fila += 2; break;
                case "UR": col += 1; fila += 2; break;
                case "LU": col -= 2; fila += 1; break;
                case "LD": col -= 2; fila -= 1; break;
                case "RU": col += 2; fila += 1; break;
                case "RD": col += 2; fila -= 1; break;
                case "DL": col -= 1; fila -= 2; break;
                case "DR": col += 1; fila -= 2; break;
            }

            string pos = ((char)('A' + col)).ToString() + fila;

            if (frutos.ContainsKey(pos))
            {
                recogidos.Add(frutos[pos]);
            }
        }

        Console.Write("Los frutos recogidos son: ");

        foreach (char f in recogidos)
            Console.Write(f + " ");
    }
}
