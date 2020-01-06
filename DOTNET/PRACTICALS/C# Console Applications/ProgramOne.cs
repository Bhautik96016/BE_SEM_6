using System;

class ProgramOne {
  public static void Main() {
    Console.Write("Enter your name: ");
    string name = Console.ReadLine();
    Console.Write("Enter your country name: ");
    string country = Console.ReadLine();
    Console.WriteLine($"Hello {name} from country {country}!");
  }
}
