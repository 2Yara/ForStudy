using System;

class Programm 
{
  static void Main() 
  {
    Console.WriteLine("Enter x: ");

    double x = Convert.toDouble(Console.ReadLine());

    if ((-10 <= x) && (x <= -6)) {
      return;
    }
    else if ((-6 <= x) && (x < 2)) {
      return;
    }
    else if ((6 <= x) && (x <= 8)) {
      return;
    }
    else {
      Console.WriteLine("");
      return;
    } 
  }
}
