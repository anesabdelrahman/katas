namespace Katas.LeetCode
{
    public class MiddleOfLinkedList
    {
        public Node MiddleNode(LinkedList head)
        {
            Node middle = head.Head;
            Node end = head.Head;

            while (end?.Next != null)
            {
                middle = middle.Next;
                end = end.Next.Next;
            }

            return middle;
        }
    }

    public class Node(int x)
    {
        public int Value = x;
        public Node Next;
    }

    // A linked list class
    public class LinkedList
    {
        public Node Head;
        
        public void Insert(int x)
        {
            var temp = new Node(x);

            if (Head == null)
            {
                Head = temp;
                return;
            }

            Node t = Head;
            while (t.Next != null)
            {
                t = t.Next;
            }

            t.Next = temp;
        }
        public bool AreNodesEqual(Node node1, Node node2)
        {
            while (node1 != null && node2 != null)
            {
                if (node1.Value != node2.Value)
                    return false;

                node1 = node1.Next;
                node2 = node2.Next;
            }

            return node1 == null && node2 == null;
        }
    }
}
