using System;

class Program {
  static void Main() {
    Console.WriteLine("Введите радиус: ");
    double R = Convert.toDouble(Console.ReadLine());
    Console.WriteLine("Введите координату x: ");
    double x = Convert.toDouble(Console.ReadLine());
    double y;
    if (x >= -R && x <= 0) {
      Console.WriteLine("Введите координату y: ");
      double y1 = Convert.toDouble(Console.ReadLine());
      //написать функцию, в которой у сравнивается с R и если координата у = R или меньше 
      //и сделать сравнение у и у1, т к прямые у = х и у = -х 
      if () {
        return;
      }
    }
    else if ((x >= 0) && (x <= R)) {
      y = Math.Sqrt(R*R - x*x);
      //сделать сравнение у и у1 и если они совпадают или у1 меньше/больше у то точка входит в серую окружность
      if () {
        return;
      }
    }
    else {
      Console.WriteLine("Координата не входит в область");
      return;
    }
  }
}
