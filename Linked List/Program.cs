using System;
using Linked_List;

var list = new Linked_List.LinkedList<string>();

list.AddFirst(new Node<string>("Goshko"));
list.AddFirst(new Node<string>("Hristiqn"));
list.AddFirst(new Node<string>("Kristiqncho"));
list.AddFirst(new Node<string>("Kaloyancho"));
list.AddLast(new Node<string>("Kirkata"));

list.Show();
Console.WriteLine(list.Contains(15));
Console.WriteLine(list.IndexOf(16));

list.DeleteFirst();
list.Show();

list.Reverse();
list.Show();
