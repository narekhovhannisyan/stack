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
      else throw new Exception("Stack is empty!");
    }

    public bool isEmpty() => top == null ? true : false;
  }
}