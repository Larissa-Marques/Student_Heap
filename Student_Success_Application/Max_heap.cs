namespace GPA_Heap
{
    public class Node
    {
        public decimal data;
        public Node left;
        public Node right;
        public Node parent;

        public Node(decimal data)
        {
            this.data = data;
        }
    }

    class Max_heap
    {
        public Node root;
        public Node current;

        public Max_heap(Node node)
        {
            root = node;
            current = node;
        }

        public void insert(Node node)
        {
            if (current.left == null)
            {
                current.left = node;
                node.parent = current;
            }
            else
            {
                current.right = node;
                node.parent = current;
                adjust_insert_pos();
            }
            balance_heap(node);
        }

        public void balance_heap(Node node)
        {
            while (node.parent != null)
            {
                if (node.parent.data < node.data)
                {
                    decimal gpa = node.data;
                    node.data = node.parent.data;
                    node.parent.data = gpa;
                    node = node.parent;
                }
                else break;
            }
        }

        public void adjust_insert_pos()
        {
            Node node;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                node = queue.Dequeue();

                if (node.left != null) queue.Enqueue(node.left);
                else
                {
                    current = node;
                    break;
                }

                if (node.right != null)
                    queue.Enqueue(node.right);
                else
                {
                    current = node;
                    break;
                }
            }
        }
    }
}
