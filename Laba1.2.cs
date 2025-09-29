using System;

class Programm
{
    static void Main()
    {
        Console.WriteLine("Введите a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        double t1 = (a + 2) / Math.Sqrt(2 * a);
        double t2 = a / (Math.Sqrt(2 * a) + 2);
        double t3 = 2 / (a - Math.Sqrt(2 * a));
        double t4 = (Math.Sqrt(a) - Math.Sqrt(2)) / (a + 2);

        double z1 = (t1 - t2 + t3) * t4;

        double z2 = 1/(Math.Sqrt(a) + Math.Sqrt(2));

        Console.WriteLine($"z1 = {z1:F6}");
        Console.WriteLine($"z2 = {z2:F6}");
    }
}
