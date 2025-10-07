using System;

class Programm 
{
  static int Fun(int x, int y) {
    int y;
    if ((-10 <= x) && (x <= -6)) {
      int R = 2;
      y = Math.Sqrt(R*R - (x+8)*(x+8)) - 2;
      Console.WriteLine($"if x = {x}");
      Console.WriteLine($"then y = {y}");
      return x, y;
    }
    else if ((-6 < x) && (x <= 2)) {
      y = 1 + x/2;
      Console.WriteLine($"if x = {x}");
      Console.WriteLine($"then y = {y}");
      return  x, y;
    }
    else if ((2 < x) && (x < 6)) {
      y = 0;
      Console.WriteLine($"if x = {x}");
      Console.WriteLine($"then y = {y}");
      return x, y;
    }
    else if ((6 <= x) && (x <= 8)) {
      y = Math.Pow((x - 6), 2);
      Console.WriteLine($"if x = {x}");
      Console.WriteLine($"then y = {y}");
      return x, y;
    }
    else {
      Console.WriteLine("f(x) is not defined");
      return;
    }
  }
  static void Main() 
  {  
    Console.WriteLine("Insert x(0), x(end) and dx: ");
    //double x0 = Convert.toInt(Console.ReadLine());
    //double xEnd = Convert.toInt(Console.ReadLine());    
    //double dx = Convert.toInt(Console.ReadLine());
    int x0 = -10;
    int xEnd = 10;
    int dx = 2;
    for (int i = x0; i <= xEnd; i+dx) {
      int y = Fun(i, y); 
    }
     return;    
  }
}
