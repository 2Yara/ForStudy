using System;

class Programm 
{
  static int Fun(int x, int y) {
    int x = 10;
    if ((-10 <= x) && (x <= -6)) {
      int R = 2;
      y = Math.Sqrt(R*R - (x+8)*(x+8)) - 2;
      Console.WriteLine($"if x = {x}");
      Console.WriteLine($"then y = {y}");
      return;
    }
    else if ((-6 < x) && (x <= 2)) {
      y = 1 + x/2;
      Console.WriteLine($"if x = {x}");
      Console.WriteLine($"then y = {y}");
      return;
    }
    else if ((2 < x) && (x < 6)) {
      y = 0;
      Console.WriteLine($"if x = {x}");
      Console.WriteLine($"then y = {y}");
      return;
    }
    else if ((6 <= x) && (x <= 8)) {
      y = Math.Pow((x - 6), 2);
      Console.WriteLine($"if x = {x}");
      Console.WriteLine($"then y = {y}");
      return;
    }
    else {
      Console.WriteLine("f(x) is not defined");
      return;
    }
  }
  static void Main() 
  {
    //double x = Convert.toDouble(Console.ReadLine());
    for (int i = -10; i <= x; i++) {
      int y = Fun(i, y); 
    }
     return;    
  }
}
