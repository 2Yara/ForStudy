using System;

class Programm {
    static void Main() {
        Console.WriteLine("Введите х в градусах: ");
        double xDegrees = Convert.ToDouble(Console.ReadLine());
        double xRadians = xDegrees * Math.PI / 180;

        Console.WriteLine("Введите у в градусах: ");
        double yDegrees = Convert.ToDouble(Console.ReadLine());
        double yRadians = yDegrees * Math.PI / 180;

        double cos4 = Math.Pow(Math.Cos(xRadians), 4);
        double sin2y = Math.Pow(Math.Sin(yRadians), 2);
        double sin22x = Math.Pow(Math.Sin(2 * xRadians), 2);

        double z1 = cos4 + sin2y + (sin22x/4) - 1;

        double z2 = Math.Sin(yRadians + xRadians) * Math.Sin(yRadians - xRadians);
        
        Console.WriteLine($"z1 = {z1:F6}");
        Console.WriteLine($"z2 = {z2:F6}");
    }
}
