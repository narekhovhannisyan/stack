using System;

namespace arrayBasedStack
{
  class Program
  {
    static void Main(string[] args)
    {
      Stack newStack = new Stack();
      newStack.push(5);
      newStack.log();
      newStack.pop();
      newStack.log();
    }
  }
  public class Stack
  {
    private int[] stack = new int[0];
    public int push(int current)
    {
      int stackResizedLength = stack.Length + 1;
      Array.Resize(ref stack, stackResizedLength);
      stack[stackResizedLength - 1] = current;
      return stack[stackResizedLength - 1];
    }
    public int pop()
    {
      int stackResizedLength = stack.Length - 1;
      int popedValue = stack[stack.Length - 1];
      Array.Resize(ref stack, stackResizedLength);
      return popedValue;
    }

    public void log()
    {
      if (stack.Length > 0)
      {
        for (int i = 0; i < stack.Length; i++)
        {
          Console.WriteLine(stack[i]);
        }
      }
      else
      {
        Console.WriteLine("End of the Stack");
      }
    }
  }
}
