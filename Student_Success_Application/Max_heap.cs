using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Heap
{
    class Max_heap
    {
        public Node root;
        public Node insert_pos;

        public Max_heap(Node node)
        {
            root = node;
            insert_pos = node;
        }
        public void insert(Node n)
        {
            if (insert_pos.left == null)
            {
                insert_pos.left = n;
                n.parent = insert_pos;

                balance_heap(n);

                return;
            }
            else
            {
                insert_pos.right = n;
                n.parent = insert_pos;

                adjust_insert_pos();
                balance_heap(n);
            }
        }
        public void balance_heap(Node n)
        {
            while (n.parent != null)
            {
                if (n.parent.data < n.data)
                {
                    decimal gpa = n.data;
                    n.data = n.parent.data;
                    n.parent.data = gpa;

                    n = n.parent;
                }
                else
                {
                    break;
                }
            }
        }
        public void adjust_insert_pos()
        {
            Node node;

            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                node = q.Dequeue();

                if (node.left != null)
                    q.Enqueue(node.left);
                else
                {
                    insert_pos = node;
                    break;
                }

                if (node.right != null)
                    q.Enqueue(node.right);
                else
                {
                    insert_pos = node;
                    break;
                }
            }
        }
    }
}
