using System;

class Program {
    static double ArcTanTaylor(double x, double epsilon, out int termCount) {
        if (x <= 1) {
            throw new ArgumentException("x должен быть больше 1");
        }
        double sum = Math.PI / 2; // начальное значение π/2
        termCount = 0;
        double term;
        
        do {
            term = Math.Pow(-1, termCount + 1) / ((2 * termCount + 1) * Math.Pow(x, 2 * termCount + 1));
            sum += term;
            termCount++;
        }
        while (Math.Abs(term) >= epsilon && termCount < 1000);
        return sum;
    }
    
    static void Main() {
        Console.WriteLine("Формула: arctg(x) = π/2 - 1/x + 1/(3x³) - 1/(5x⁵) + ..., x > 1");
        Console.WriteLine();
        
        // Console.Write("Введите начальное значение x (x > 1): ");
        // double xStart = Convert.toDouble(Console.ReadLine());
        double xStart = 1.1;
        // Console.Write("Введите конечное значение x: ");
        // double xEnd = Convert.toDouble(Console.ReadLine());
        double xEnd = 10;
        // Console.Write("Введите шаг dx: ");
        // double dx = Convert.toDouble(Console.ReadLine());
        double dx = 1;
        // Console.Write("Введите точность ε: ");
        // double epsilon = Convert.toDouble(Console.ReadLine());
        double epsilon = 1E-08;
        
        if (xStart <= 1) {
            Console.WriteLine("Ошибка: начальное значение x должно быть больше 1");
            return;
        }
        if (xEnd < xStart) {
            Console.WriteLine("Ошибка: конечное значение x не может быть меньше начального");
            return;
        }
        if (dx <= 0) {
            Console.WriteLine("Ошибка: шаг dx должен быть положительным");
            return;
        }
        Console.WriteLine();
        Console.WriteLine("==================================================");
        Console.WriteLine("|   x    |   arctg(x)   | Членов ряда | Погрешность |");
        Console.WriteLine("==================================================");
        
        for (double x = xStart; x <= xEnd; x += dx){
            try {
                int terms;
                double result = ArcTanTaylor(x, epsilon, out terms);
                double exact = Math.Atan(x);
                double error = Math.Abs(result - exact);
                
                Console.WriteLine($"| {x,6:F2} | {result,11:F8} | {terms,11} | {error,10:E2} |");
            }
            catch (Exception ex) {
                Console.WriteLine($"| {x,6:F2} | {ex.Message,-11} |            |             |");
            }
        }
        
        Console.WriteLine("==================================================");
        return 0;
    }
}
