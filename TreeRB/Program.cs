using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeRB
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTree tree = new MyTree();
            tree.Add(10);
            tree.Add(9);
            tree.Add(15);
            tree.Add(7);
            tree.Add(20);
            tree.Print();
        }
    }
}
