using System;

class Programm {
    static void Main() {
        Console.WriteLine("Введите х в градусах: ");
        double x = Convert.ToDouble(Console.ReadLine());
        double xRadians = xDegrees * Math.PI / 180;

        Console.WriteLine("Введите у в градусах: ");
        double y = Convert.ToDouble(Console.ReadLine());
        double yRadians = yDegrees * Math.PI / 180;

        double z1 = Math.Cos(Math.Pow(xRadians, 4)) + Math.Sin(Math.Pow(yRadians, 2)) + (Math.Sin(Math.Pow(2*xRadians, 2))/4) - 1;

        double z2 = Math.Sin(yRadians + xRadians) * Math.Sin(yRadians - xRadians);
        
        Console.WriteLine($"z1 = {z1:F6}");
        Console.WriteLine($"z2 = {z2:F6}");
    }
}
