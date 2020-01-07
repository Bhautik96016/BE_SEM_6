using System;

class ProgramFive {
  public static void Main () {
    Console.WriteLine("Welcome to Temprature Convertor!!");
    Console.WriteLine("1. Celcius to Farenhit");
    Console.WriteLine("2. Farenhit to Celcius");
    Console.Write("Enter your choice: ");
    int choice = int.Parse(Console.ReadLine());
    float result = 0;
    switch(choice) {
      case 1:
        Console.Write("Enter Celcius: ");
        float celcius = float.Parse(Console.ReadLine());
        result = (celcius*9/5)+32;
        Console.WriteLine($"Farenhit: {result}");
        break;
      case 2:
        Console.Write("Enter Farenhit: ");
        float farenhit = float.Parse(Console.ReadLine());
        result = (farenhit-32)*5/9;
        Console.WriteLine($"Celcius: {result}");
        break;
      default:
        Console.WriteLine("Invalid Choice!!");
        break;
    }
  }
}
