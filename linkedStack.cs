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
      stack.pop();
      stack.pop();
      Console.WriteLine(stack.lastItem());
      Console.WriteLine(stack.isEmpty());
    }
  }
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

    public int? lastItem()
    {
      if (top != null) return top.Value;
      else return null;
    }

    public bool isEmpty() => top == null ? true : false;
  }
}