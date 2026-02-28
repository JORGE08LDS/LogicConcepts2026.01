using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Time t1 = new Time();
            Time t2 = new Time(14);
            Time t3 = new Time(9, 34);
            Time t4 = new Time(19, 45, 56);
            Time t5 = new Time(23, 3, 45, 678);

            Time[] times = { t1, t2, t3, t4, t5 };

            foreach (Time t in times)
            {
                Console.WriteLine($"Time: {t}");

                Console.WriteLine($"        {"Milliseconds:",-14}{t.ToMilliseconds(),15:N0}");
                Console.WriteLine($"        {"Seconds     :",-14}{t.ToSeconds(),15:N0}");
                Console.WriteLine($"        {"Minutes     :",-14}{t.ToMinutes(),15:N0}");

                Time added = t.Add(t3);
                Console.WriteLine($"        {"Add         :",-14}{added}");

                Console.WriteLine($"        {"Is Other day:",-14}{t.IsOtherDay(t4)}");
                Console.WriteLine();
            }

            // Invalid test
            Time invalid = new Time(45);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
