using System;

class ProgramSix {

  public static void DecimalToBinary(int dec) {
    int[] binary = new int[16];
    int i = 0, prevDec = 0;

    while(dec >=1 ) {
      prevDec = dec;
      dec = (int)(dec / 2);
      binary[i] = prevDec % 2;
      i+=1;
    }
    Console.WriteLine("=============================");
    for(int iterator=binary.Length-1; iterator>=0; iterator--) {
      Console.Write($"{binary[iterator]}");
    }
     Console.WriteLine("\n=============================");
  }

  public static void DecimalToOctal(int dec) {
    int[] octal = new int[16];
    int i=0, prevDec=0;

    while(dec >= 1) {
      prevDec = dec;
      dec = (int)(dec / 8);
      octal[i] = prevDec % 8;
      i+=1;
    }

    Console.WriteLine("=============================");
    for(int iterator=octal.Length-1; iterator>=0; iterator--) {
      Console.Write($"{octal[iterator]}");
    }
     Console.WriteLine("\n=============================");

  }

  public static void DecimalToHexaecimal(int dec) {
      int[] hex = new int[16];
      int i=0, prevDec=0;

      while(dec >= 1) {
        prevDec = dec;
        dec = (int)(dec / 16);
        hex[i] = prevDec % 16;
        i+=1;
      }

      Console.WriteLine("=============================");
      for(int iterator=hex.Length-1; iterator>=0; iterator--) {
        if(hex[iterator] == 10) {
          Console.Write("A");
        }
        else if(hex[iterator] == 11) {
          Console.Write("B");
        }
        else if(hex[iterator] == 12) {
          Console.Write("C");
        }
        else if(hex[iterator] == 13) {
          Console.Write("D");
        }
        else if(hex[iterator] == 14) {
          Console.Write("E");
        }
        else if(hex[iterator] == 15) {
          Console.Write("F");
        }
        else {
          Console.Write(hex[iterator]);
        }
      }
      Console.WriteLine("\n=============================");
  }

  public static void Main () {
    Console.WriteLine ("Welcome to Convertor!!");
    Console.Write("Enter Decimal number: ");
    int dec = int.Parse(Console.ReadLine());
    Console.WriteLine("1. Decimal to Binary");
    Console.WriteLine("2. Decimal to Octal");
    Console.WriteLine("3. Decimal to Hexadecimal");
    Console.Write("Enter your choice: ");
    int choice = int.Parse(Console.ReadLine());
    switch(choice) {
      case 1:
        DecimalToBinary(dec);
        break;
      case 2: 
        DecimalToOctal(dec);
        break;
      case 3:
        DecimalToHexaecimal(dec);
        break;
      default:
        Console.WriteLine("Invalid choice");
        break;
    }
    Console.WriteLine("\nProgram Exited!!");
  }
}