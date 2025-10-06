using System;

class Program {
  static void Main() {
    Console.WriteLine("Введите радиус: ");
//    double R = Convert.toDouble(Console.ReadLine());
    double R = 5;
    Console.WriteLine("Введите координату x: ");
//    double x = Convert.toDouble(Console.ReadLine());
    double x = 1;
    Console.WriteLine("Введите координату y: ");
    //double y1 = Convert.toDouble(Console.ReadLine());
    double y1 = 1;
    double y;
    if (x >= -R && x <= 0) {
      y = -x; 
      double y2 = x;
      if (y1 >= 0 && y1 <= y) {
        Console.WriteLine($$"Координата [{x:F6},{y1:F6}] входит в область");
        return;
      }
      if (y1 <= 0 && y1 >= y2) {
        Console.WriteLine($$"Координата [{x:F6},{y1:F6}] входит в область");
        return;
      }
    }
    else if ((x >= 0) && (x <= R)) {
      y = Math.Sqrt(R*R - x*x);
      if ((y >= y1) && (-y <= y1)) {
        Console.WriteLine($$"Координата [{x:F6},{y1:F6}] входит в область");
        return;
      }
    }
    else {
      Console.WriteLine("Координата не входит в область");
      return;
    }
  }
}
