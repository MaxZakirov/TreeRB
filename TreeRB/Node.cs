using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeRB
{
    class Node
    {
        public bool IsBlack { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node Parent { get; set; }
        public int Value { get; set; }

        public Node(int value,bool IsBlack=false)
        {
            Value = value;
            this.IsBlack = IsBlack;
        }
    }
}
