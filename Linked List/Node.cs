namespace Linked_List;

public class Node<T>
{
    public Node<T>? next;
    public object value { get; private set; }

    public Node(T obj)
    {
        value = obj;
    }
}