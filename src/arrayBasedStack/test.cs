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
}
