do
{
    Console.Write("Ingrese un numero o presione CTR + c Para salir: ");
    double N1 = double.Parse(Console.ReadLine()!);
    if (N1 % 2 == 0)
    {
        Console.WriteLine($"El numero {N1} es PAR");
    }
    else
    {
        Console.WriteLine($"El numero {N1} es IMPAR");
    }
} while (true);







