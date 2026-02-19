do
{
    Console.Write("Ingrese el primer número: ");
    double N1 = double.Parse(Console.ReadLine()!);
    Console.Write("Ingrese el segundo número: ");
    double N2 = double.Parse(Console.ReadLine()!);
    Console.Write("Ingrese el tercer número: ");
    double N3 = double.Parse(Console.ReadLine()!);

    if (N1 > N2 && N1 > N3)
    {
        Console.WriteLine($"El numero {N1}, es el mayor");
    }
    else if (N2 > N1 && N2 > N3)
    {
        Console.WriteLine($"El numero {N2}, es el mayor");

    }
    else
    {
        Console.WriteLine($"El numero {N3}, es el mayor");

    }
} while (true);