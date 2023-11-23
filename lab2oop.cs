using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть x1Min: ");
        double x1Min = double.Parse(Console.ReadLine());

        Console.Write("Введіть x1Max: ");
        double x1Max = double.Parse(Console.ReadLine());

        Console.Write("Введіть dx1: ");
        double dx1 = double.Parse(Console.ReadLine());

        Console.Write("Введіть x2Min: ");
        double x2Min = double.Parse(Console.ReadLine());

        Console.Write("Введіть x2Max: ");
        double x2Max = double.Parse(Console.ReadLine());

        Console.Write("Введіть dx2: ");
        double dx2 = double.Parse(Console.ReadLine());
        double x1 = x1Min;
        double x2;
        double y;
        double product = 1; 

        while (x1 <= x1Max)
        {
            x2 = x2Min;

            while (x2 <= x2Max)
            {
                y = Math.Cos(Math.Pow(Math.Exp((x1 + 2 * x2 + 9) / 0.666), 3));
                Console.WriteLine($"x1 = {x1}, x2 = {x2}, y = {y:F2}");
                if (y < 0)
                {
                    product *= y;
                }
                x2 += dx2;
            }
            x1 += dx1;
        }
        Console.WriteLine($"Добуток від'ємних значень: {product:F2}");
        Console.ReadKey();
    }
}
