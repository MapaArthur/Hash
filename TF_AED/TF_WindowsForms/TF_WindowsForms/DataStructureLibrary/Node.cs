using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresLibrary
{
    class Node
    {
        private Data data;
        private Node left;
        private Node right;

        public Data Data { get => data; }
        internal Node Left { get => left; set => left = value; }
        internal Node Right { get => right; set => right = value; }

        public Node(Data d)
        {
            this.data = d;
            this.left = null;
            this.right = null;
        }
        public int CompareTo(Node other)
        {
            return this.data.CompareTo(other.data);
        }

        public bool Equals(Node other)
        {
            return this.data.Equals(other.data);
        }
    }
}
