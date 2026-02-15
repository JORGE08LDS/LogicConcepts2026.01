var numberString = string.Empty;
do
{
    Console.Write("Ingrese número o 'S' para salir:  ");
    numberString = Console.ReadLine();
    if (numberString!.ToLower() == "S")
    {
        Console.WriteLine("Saliendo del programa...");
        break;
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

} while (numberString!.ToLower() != "S");



