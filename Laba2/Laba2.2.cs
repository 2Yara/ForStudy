using System;

class Programm 
{
  static void Main() 
  {
  Console.WriteLine("Enter x: ");

    double x = Convert.toDouble(Console.ReadLine());
    double y;

    if ((-10 <= x) && (x <= -6)) {
      double R = 2;
      y = Math.Sqrt(R*R - (x+8)*(x+8)) - 2;
      Console.WriteLine($"if x = {x:F6}");
      Console.WriteLine($"then y = {y:F6}");
      return;
    }
    else if ((-6 < x) && (x <= 2)) {
      y = 1 + x/2;
      Console.WriteLine($"if x = {x:F6}");
      Console.WriteLine($"then y = {y:F6}");
      return;
    }
    else if ((2 < x) && (x < 6)) {
      y = 0;
      Console.WriteLine($"if x = {x:F6}");
      Console.WriteLine($"then y = {y:F6}");
      return;
    }
    else if ((6 <= x) && (x <= 8)) {
      y = Math.Pow((x - 6), 2);
      Console.WriteLine($"if x = {x:F6}");
      Console.WriteLine($"then y = {y:F6}");
      return;
    }
    else {
      Console.WriteLine("f(x) is not defined");
      return;
    }     
  }
}

// func Lab22() {}

// Console.WriteLine("Enter lab num: ");
//     char labNum = (char)Console.ReadLine();
//     bool 
//     switch(labNum) {
//       case '2' : func Lab22 break;
//       case '3' : func Lab32 break;
//         default : 
//     }
    
