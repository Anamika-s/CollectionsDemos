using System;
using System.Collections.Generic;

class Program{
  static void Main()
  {
    List<int> list = new  List<int>();
    list.Add(1);
    list.Add(2);
    list.Add(4);
    foreach(int x in list)
    Console.WriteLine(x);

    Stack<string> stack = new Stack<string>();
    stack.Push("AAA");

    Queue<int> queue = new Queue<int>();
    queue.Enqueue(1);


    Dictionary<string,int>  records = new  Dictionary<string, int>();
    records["Deepak"]= 100;

  }
}