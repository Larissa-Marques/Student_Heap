using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Heap
{
    public class Node
    {
        public Node left;
        public Node right;
        public Node parent;

        public decimal data;

        public Node(decimal data)
        {
            this.data = data;
        }
    }
}
