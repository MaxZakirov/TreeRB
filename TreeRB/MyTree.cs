using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeRB
{
    class MyTree
    {
        private Node root;
        private short LBH;
        private short RBH;


        public MyTree()
        {
            root = null;
            LBH = RBH = 0;
        }

        public void Print()
        {
            if(root!=null)
                PrintRecursive(root);
        }

        private void PrintRecursive(Node node)
        {
            char color = node.IsBlack ? 'b' : 'r';
            Console.WriteLine(node.Value.ToString() + color);
            if (node.Left != null)
                PrintRecursive(node.Left);
            if (node.Right != null)
                PrintRecursive(node.Right);
        }

        public void Add(int val)
        {
            if (root == null)
            {
                root = new Node(val, true);
                LBH = RBH = 1;
            }
            else
                AddRecursive(val, root);
            if (LBH != RBH)
            {
                Recolor(root.Left,ref LBH);
                Recolor(root.Right,ref RBH);
            }
        }

        private void Recolor(Node n,ref short H)
        {
            if(n.IsBlack)
                H--;
            else
                H++;
            n.IsBlack = !n.IsBlack;
            if (n.Left != null)
                Recolor(n.Left,ref H);
            if (n.Right != null)
                Recolor(n.Right,ref H);
        }

        private void RightRotate(Node n)
        {
            Node boof = n;
            n = n.Left;
            AddRecursive(n)
        }

        private void AddRecursive(int val,Node node)
        {
            bool isBlacked = !node.IsBlack;
            if (node.Value>val)
            {
                if (node.Left == null)
                {
                    node.Left = new Node(val, isBlacked);
                    if (isBlacked)
                        LBH++;
                }
                else
                    AddRecursive(val, node.Left);
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new Node(val, isBlacked);
                    if (isBlacked)
                        RBH++;
                }
                else
                    AddRecursive(val, node.Right);
            }
        }
    }
}
