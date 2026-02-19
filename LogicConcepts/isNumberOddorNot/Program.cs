var numberString = string.Empty;
do
{
    Console.WriteLine("Ingrese número o 's' para salir:  ");
    numberString = Console.ReadLine();
    if (numberString!.ToLower() == "s")
    {
        continue;        
    }
    var numberInt = 0;
    if (int.TryParse(numberString, out numberInt))
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El número {numberInt}, es par");
        }
        else
        {
            Console.WriteLine($"El número {numberInt}, es impar");
        }
    }
    else
    {
        Console.WriteLine($"El valor {numberString} no es un número válido");
    }

} while (numberString != "s");
Console.WriteLine("Saliendo del programa...");


