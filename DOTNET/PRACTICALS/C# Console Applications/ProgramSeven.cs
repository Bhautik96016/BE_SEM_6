using System;

class ProgramSeven {

  public static char[] stack = new char[1000];
  public static int top = -1;

  public static void push(char c) {
    top+=1;
    stack[top] = c;
  }

  public static char pop() {
    char c = stack[top];
    top-=1;
    return c;
  }


  public static string InfixToPostfix(string infixString) {
    string postfix = "";
    foreach(char c in infixString) {
      if(c == '(' || c == '+' || c == '-' || c == '*' || c == '/') {
        // push to stack
        push(c);
      }

      else if(c == ')') {
        // pop from stack
        char sign;
        while((sign = pop())!='(') {
          postfix+=sign;
        }
      }

      else {
        postfix+=c;
      }
    }

    // Append Remaing items
    for(int i=0; i<=top; i++) {
      postfix+=stack[i];
    }
    return postfix;
  }

  public static void Main () {
    Console.Write("Enter Infix String: ");
    string infix = Console.ReadLine();
    string postfix = InfixToPostfix(infix);
    Console.WriteLine(postfix);
  }
}
