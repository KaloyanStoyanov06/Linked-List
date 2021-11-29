using System;

namespace Linked_List;

public class LinkedList<T>
{
    private Node<T> first;
    private Node<T> last;
    
    // addFirst
    public void AddFirst(Node<T> node)
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
    public void AddLast(Node<T> node)
    {
        last.next = node;
        last = node;
    }

    // deleteFirst
    public object DeleteFirst()
    {
        var value = first.value;
        first = first.next;

        return value;
    }

    // deleteLast
    public void DeleteLast()
    {
        Node<T> temp = first;
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
    public bool Contains(object Value)
    {
        Node<T> temp = first;
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
    public int IndexOf(object Value)
    {
        int index = 0;
        Node<T> temp = first;
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
        Node<T> temp = first;
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

    public void Reverse(Node<T>? node = null)
    {
        Node<T>? prev = null;
        Node<T> curr = first;
        Node<T>? next = null;

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