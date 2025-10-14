using System;

class Program {
  double R = 5;
  static void Mishen(double Xshot, double Yshot) {
    double y;
    if (Xshot >= -R && Xshot <= 0) {
      y = R; 
      double y2 = -R;
      if ((Yshot > 0) && (Yshot <= R && Yshot >= y)) {
        Console.WriteLine($"Bullet [{Xshot:F2},{Yshot:F2}] hit the target");
        return;
      }
      else if ((Yshot < 0) && (Yshot >= -R && Yshot <= y)) {
        Console.WriteLine($"Bullet [{Xshot:F2},{Yshot:F2}] hit the target");
        return;
      }
      else {
          Console.WriteLine("Bullet [{Xshot:F2},{Yshot:F2}] DID NOT hit the target");
      }
    }
    else if ((Xshot >= 0) && (Xshot <= R)) {
      y = Math.Sqrt(R*R - R*R);
      if ((y >= Yshot) && (-y <= Yshot)) {
        Console.WriteLine($"Bullet [{Xshot:F2},{Yshot:F2}] hit the target");
        return;
      }
    }
    else {
      Console.WriteLine("Bullet [{Xshot:F2},{Yshot:F2}] DID NOT hit the target");
      return;
    }
  }

  
  static void Main() {
 //   Console.WriteLine("Insert radius: ");
//    double R = Convert.toDouble(Console.ReadLine());
//    Console.WriteLine("Insert coordinate x: ");
//    double x = Convert.toDouble(Console.ReadLine());
//    Console.WriteLine("Insert coordinate y: ");
//    double y1 = Convert.toDouble(Console.ReadLine());
        Random rand = new Random();
        
        for (int i = 0; i < 10; i++) 
        {
            double Xshot = rand.NextDouble(-6, 7); // от -6 до 6
            double Yshot = rand.NextDouble(-6, 7); // от -6 до 6
            
            Mishen(Xshot, Yshot);
    return;
     }
  }
}
