using System;

namespace stack_namespace
{
  class linkedStack
  {
    static void Main(string[] args)
    {
      lStack stack = new lStack();
      stack.push(5);
      stack.push(6);
      Console.WriteLine(stack.peek());
      Console.WriteLine(stack.isEmpty());
      stack.pop();
      stack.pop();
      Console.WriteLine(stack.peek());
      Console.WriteLine(stack.isEmpty());
    }
  }
}