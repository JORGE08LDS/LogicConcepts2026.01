using System;

class PuentesMadison
{
    static void Main()
    {
        while (true)
        {
            Console.Write("\nIngrese el puente (o escriba SALIR): ");
            string puente = Console.ReadLine();

            if (puente.ToUpper() == "SALIR")
                break;

            if (EsValido(puente))
                Console.WriteLine("VALIDO");
            else
                Console.WriteLine("INVALIDO");
        }
    }

    static bool EsValido(string p)
    {
        if (p.Length < 2)
            return false;

        // Validar que empiece y termine con base
        if (p[0] != '*' || p[p.Length - 1] != '*')
            return false;

        // Validar que no haya bases en el centro
        for (int i = 1; i < p.Length - 1; i++)
        {
            if (p[i] == '*')
                return false;
        }

        // Validar simetría
        char[] arr = p.ToCharArray();
        Array.Reverse(arr);
        string rev = new string(arr);

        if (p != rev)
            return false;

        // Validar máximo 3 plataformas seguidas
        int contador = 0;

        foreach (char c in p)
        {
            if (c == '=')
            {
                contador++;
                if (contador > 3)
                    return false;
            }
            else
            {
                contador = 0;
            }
        }

        return true;
    }
}
