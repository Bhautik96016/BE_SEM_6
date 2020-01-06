using System;

// 1 One
// 11 Eleven
// 111 One Hundred 11
// 1111 One Thousand 111
class ProgramThree {

  public static string SingleDigit(int n) {
    switch(n) {
      case 1:
        return "One";
      case 2:
        return "Two";
      case 3:
        return "Three";
      case 4:
        return "Four";
      case 5:
        return "Five";
      case 6:
        return "Six";
      case 7:
        return "Seven";
      case 8:
        return "Eight";
      case 9:
        return "Nine";
    }
    return "";
  }

  public static string TwoDigit(int n) {
    switch(n) {
      case 1:
        return "Ten";
      case 2:
        return "Twenty";
      case 3:
        return "Thirty";
      case 4:
        return "Fourty";
      case 5:
        return "Fifty";
      case 6:
        return "Sixty";
      case 7:
        return "Seventy";
      case 8:
        return "Eighty";
      case 9:
        return "Ninty";
    }
    return "";
  }


  public static string ThreeDigit(int n) {
    switch(n) {
      case 1:
        return "One Hundred";
      case 2:
        return "Two Hundred";
      case 3:
        return "Three Hundred";
      case 4:
        return "Four Hundred";
      case 5:
        return "Five Hundred";
      case 6:
        return "Six Hundred";
      case 7:
        return "Seven Hundred";
      case 8:
        return "Eight Hundred";
      case 9:
        return "Nine Hundred";
    }
    return "";
  }


  public static string FourDigit(int n) {
    switch(n) {
      case 1:
        return "One Thousand";
      case 2:
        return "Two Thousand";
      case 3:
        return "Three Thousand";
      case 4:
        return "Four Thousand";
      case 5:
        return "Five Thousand";
      case 6:
        return "Six Thousand";
      case 7:
        return "Seven Thousand";
      case 8:
        return "Eight Thousand";
      case 9:
        return "Nine Thousand";
    }
    return "";
  }

  public static void NumberToDigit(string no) {
    int noInt = int.Parse(no);
      if(no.Length == 1) {
        Console.Write(SingleDigit(noInt));
      }
      if(no.Length == 2) {
        int sl = noInt / 10;
        int ml = noInt % 10;
        if(noInt>9 && noInt<20)
          TenToNinghty(noInt);
        else {
          Console.Write(TwoDigit(sl)+" ");
          Console.Write(SingleDigit(ml));
        }
      }
      if(no.Length == 3) {
        int sl = noInt / 100;
        int ml = noInt % 100;
        Console.Write(ThreeDigit(sl)+" ");
        NumberToDigit(ml+"");
      }
      if(no.Length == 4) {
        int sl = noInt / 1000;
        int ml = noInt % 1000;
        Console.Write(FourDigit(sl)+" ");
        NumberToDigit(ml+"");
      }
  }

  public static void TenToNinghty(int no) {
    switch(no) {
      case 10:
        Console.Write("Ten");
        break;
      case 11:
        Console.Write("Eleven");
        break;
      case 12:
        Console.Write("Twelve");
        break;
      case 13:
        Console.Write("Thirteen");
        break;
      case 14:
        Console.Write("Fourteen");
        break;
      case 15:
        Console.Write("Fifteen");
        break;
      case 16:
        Console.Write("Sixteen");
        break;
      case 17:
        Console.Write("Seventeen");
        break;
      case 18:
        Console.Write("Eighteen");
        break;
      case 19:
        Console.Write("Nighteen");
        break;
    }
  }

  public static void Main() {
    Console.Write("Enter digits: ");
    string no = Console.ReadLine();
    if(no.Length > 4) {
      Console.WriteLine("Enter Valid number between 0 - 9999");
    }
    else {
      int noInt = int.Parse(no);
      if(noInt>9 && noInt<20)
        TenToNinghty(noInt);
      else
        NumberToDigit(no);
    }
  }
}
