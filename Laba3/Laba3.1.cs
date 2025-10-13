using System;

class Program 
{
    static void Fun(double x) 
    {
        double y;
        if ((-10 <= x) && (x <= -6)) {
            double R = 2;
            y = Math.Sqrt(R * R - (x + 8) * (x + 8)) - 2;
            Console.WriteLine($"if x = {x:F2}");
            Console.WriteLine($"then y = {y:F2}");
        } else if ((-6 < x) && (x <= 2)) {
            y = 1 + x / 2;
            Console.WriteLine($"if x = {x:F2}");
            Console.WriteLine($"then y = {y:F2}");
        } else if ((2 < x) && (x < 6)) {
            y = 0;
            Console.WriteLine($"if x = {x:F2}");
            Console.WriteLine($"then y = {y:F2}");
        } else if ((6 <= x) && (x <= 8)) {
            y = Math.Pow((x - 6), 2);
            Console.WriteLine($"if x = {x:F2}");
            Console.WriteLine($"then y = {y:F2}");
        } else {
            Console.WriteLine($"if x = {x:F2}");
            Console.WriteLine("f(x) is not defined");
        }
    }
    
    static void Main() 
    {  
        Console.WriteLine("Insert x0, xEnd and dx: ");
        // double x0 = Convert.ToDouble(Console.ReadLine());
        // double xEnd = Convert.ToDouble(Console.ReadLine());    
        // double dx = Convert.ToDouble(Console.ReadLine());
        double x0 = -10;
        double xEnd = 10;
        double dx = 3;
        
        Console.WriteLine($"\nCalculating function from {x0:F2} to {xEnd:F2} with step {dx:F2}:");
        Console.WriteLine("=========================================");
        for (double i = x0; i <= xEnd; i += dx) {
            Fun(i);
            Console.WriteLine("-----------------------------------------");
        }
    }
}
