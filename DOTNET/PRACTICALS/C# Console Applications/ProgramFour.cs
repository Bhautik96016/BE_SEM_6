using System;

/*
  Currency Price at 6 Jan, 04:26 PM IST
  $1 = 71.97
  €1 = 80.57 // Europian Union
*/

class ProgramFour {
  public static void Main() {
    Console.Write("Enter INR: ");
    float inr = float.Parse(Console.ReadLine());
    Console.WriteLine("1. INR TO USD");
    Console.WriteLine("2. INR TO EURO");
    Console.Write("Enter Your Choice: ");
    int c = int.Parse(Console.ReadLine());
    float result = 0;
    switch(c) {
      case 1:
        result = (float)(inr / 71.97);
        Console.WriteLine($"₹{inr} = ${Math.Round(result, 3)}");
        break;
      case 2:
        result = (float)(inr / 80.57);
        Console.WriteLine($"₹{inr} = €{Math.Round(result, 3)}");
        break;
      default:
        Console.WriteLine("Invalid Choice!!");
    }
  }
}
