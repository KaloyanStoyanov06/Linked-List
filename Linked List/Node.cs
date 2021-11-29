namespace Linked_List;

public class Node
{
    public Node? next;
    public int value { get; private set; }

    public Node(int Value)
    {
        value = Value;
    }
}