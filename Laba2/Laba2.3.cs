using System;

class Program {
  static void Main() {
    Console.WriteLine("Insert radius: ");
//    double R = Convert.toDouble(Console.ReadLine());
    double R = 5;
    Console.WriteLine("Insert coordinate x: ");
//    double x = Convert.toDouble(Console.ReadLine());
    double x = -4;
    Console.WriteLine("Insert coordinate y: ");
    //double y1 = Convert.toDouble(Console.ReadLine());
    double y1 = -1;
    double y;
    if (x >= -R && x <= 0) {
      y = x; 
      double y2 = -x;
      if ((y1 > 0) && (y1 <= R && y1 >= y)) {
        Console.WriteLine($"Coordinate [{x:F2},{y1:F2}] входит в область");
        return;
      }
      else if ((y1 < 0) && (y1 >= -R && y1 <= y)) {
        Console.WriteLine($"Coordinate [{x:F2},{y1:F2}] входит в область");
        return;
      }
      else {
          Console.WriteLine("Координата не входит в область");
      }
    }
    else if ((x >= 0) && (x <= R)) {
      y = Math.Sqrt(R*R - x*x);
      if ((y >= y1) && (-y <= y1)) {
        Console.WriteLine($"Coordinate [{x:F2},{y1:F2}] входит в область");
        return;
      }
    }
    else {
      Console.WriteLine("Координата не входит в область");
      return;
    }
  }
}
