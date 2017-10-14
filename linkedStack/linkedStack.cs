using System;

namespace stack_namespace
{
  class lStack
  {
    class Node
    {
      public int Value;
      public Node Next;
    }
    Node top = null;

    public void push(int value)
    {
      Node newNode = new Node();
      newNode.Next = top;
      newNode.Value = value;
      top = newNode;
    }

    public void pop()
    {
      if (top.Next != null) top = top.Next;
      else top = null;
    }

    public int? peek()
    {
      if (top != null) return top.Value;
      else return null;
    }

    public bool isEmpty() => top == null ? true : false;
  }
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