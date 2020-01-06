using System;

class ProgramTwo {
  public static void Main() {
    Console.Write("Enter the rows: ");
    int rows = int.Parse(Console.ReadLine());
    Console.Write("Enter columns: ");
    int columns = int.Parse(Console.ReadLine());
    Console.Write("Enter the char: ");
    char c = Console.ReadKey().KeyChar;
    for (int i=0; i<rows; i++) {
      Console.WriteLine("");
      for (int j=0; j<columns; j++){
        Console.Write(c);
      }
    }
  }
}
