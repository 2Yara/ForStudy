using System;

class Program {
  public class Data {
    private int year;
    private int month;
    private int day;

    private const int MinYear = 1;
    private const int MaxYear = 9999;
    private readonly int[] dayinMonth = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

    public Data() {
      DateTime today = DateTime.Today;
      year = today.Year;
      month = today.Month;
      day = today.Day;
    }

    public Data(int year, int month, int day) {
      SetDate(year, month, day);
    }

    public int Year {
      get {return year;}
      set {
        if ((value < MinYear)||(value > MaxYear)) throw new 
      }
    }
  }

  
  static void Main() {
    return 0;
  }
}
