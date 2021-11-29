using System;

namespace Linked_List;

public class LinkedList
{
    private Node first;
    private Node last;

    // addFirst
    public void AddFirst(Node node)
    {
        node.next = first;
        var temp = first;
        first = node;

        if (temp == null) return;

        while (true)
        {
            if (temp.next == null)
            {
                last = temp;
                break;
            }

            temp = temp.next;
        }
    }

    // addLast
    public void AddLast(Node node)
    {
        last.next = node;
        last = node;
    }

    // deleteFirst
    public int DeleteFirst()
    {
        var value = first.value;
        first = first.next;

        return value;
    }

    // deleteLast
    public void DeleteLast()
    {
        Node temp = first;
        while (true)
        {
            if (temp.next == last)
            {
                temp.next = null;
                break;
            }

            temp = temp.next;
        }
    }

    // contains
    public bool Contains(int Value)
    {
        Node temp = first;
        while (true)
        {
            if (temp.value == Value)
                return true;

            if (temp.next == null)
                return false;

            temp = temp.next;
        }
    }

    // indexOf
    public int IndexOf(int Value)
    {
        int index = 0;
        Node temp = first;
        while (true)
        {
            if (temp.value == Value)
            {
                return index;
            }

            if (temp.next == null)
                break;

            index++;
            temp = temp.next;
        }

        return -1;
    }

    public void Show()
    {
        Node temp = first;
        Console.Write("[");
        while (true)
        {
            Console.Write($"{temp.value},");

            if (temp.next == null)
                break;

            temp = temp.next;
        }

        Console.WriteLine("]");
    }

    public void Reverse(Node? node = null)
    {
        Node? prev = null;
        Node curr = first;
        Node? next = null;

        while (curr != null)
        {
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        first = prev;
    }
}