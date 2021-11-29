using System;
using Linked_List;

var list = new LinkedList();

list.AddFirst(new Node(15));
list.AddFirst(new Node(23));
list.AddFirst(new Node(167));
list.AddFirst(new Node(200));
list.AddLast(new Node(16));

list.Show();
Console.WriteLine(list.Contains(15));
Console.WriteLine(list.IndexOf(16));

list.DeleteFirst();
list.Show();

