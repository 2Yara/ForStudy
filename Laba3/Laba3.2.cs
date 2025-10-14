using System;

class Program {
  double R = 5;
  static void Mishen(double Xshot, double Yshot) {
    if (Xshot >= -R && Xshot <= 0) {
      if ((Yshot > 0) && (Yshot <= R && Yshot >= y)) {
        Console.WriteLine($"Bullet [{Xshot:F2},{Yshot:F2}] hit the target");
      } else if ((Yshot < 0) && (Yshot >= -R && Yshot <= y)) {
        Console.WriteLine($"Bullet [{Xshot:F2},{Yshot:F2}] hit the target");
      } else {
          Console.WriteLine("Bullet [{Xshot:F2},{Yshot:F2}] DID NOT hit the target");
      }
    } else if ((Xshot >= 0) && (Xshot <= R)) {
      if ((R >= Yshot) && (-R <= Yshot)) {
        Console.WriteLine($"Bullet [{Xshot:F2},{Yshot:F2}] hit the target");
      }
    } else {
      Console.WriteLine("Bullet [{Xshot:F2},{Yshot:F2}] DID NOT hit the target");
    }
  }

  
  static void Main() {
        Random rand = new Random();
        
        for (int i = 0; i < 10; i++) {
            double Xshot = rand.NextDouble(-6, 7); // от -6 до 6
            double Yshot = rand.NextDouble(-6, 7); // от -6 до 6
            
            Mishen(Xshot, Yshot);
        }
    return;
    }
}

