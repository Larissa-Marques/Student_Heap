namespace GPA_Heap
{
    public class Node
    {
        public decimal gpa;
        public Node left;
        public Node right;
        public Node parent;

        public Node(decimal gpa)
        {
            this.gpa = gpa;
        }
    }

    class Max_heap
    {
        public Node root;
        public Node current_parent;

        public Max_heap(Node node)
        {
            root = node;
            current_parent = node;
        }

        public void insert(Node node)
        {
            if (current_parent.left == null)
            {
                current_parent.left = node;
                node.parent = current_parent;
            }
            else
            {
                current_parent.right = node;
                node.parent = current_parent;
                fix_current_parent();
            }

            // Balance the heap
            while (node.parent != null)
            {
                if (node.parent.gpa < node.gpa)
                {
                    decimal gpa = node.gpa;
                    node.gpa = node.parent.gpa;
                    node.parent.gpa = gpa;
                    node = node.parent;
                }
                else break;
            }
        }

        private void fix_current_parent()
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
                    current_parent = node;
                    break;
                }
                if (node.right != null) queue.Enqueue(node.right);
                else
                {
                    current_parent = node;
                    break;
                }
            }
        }
    }
}
