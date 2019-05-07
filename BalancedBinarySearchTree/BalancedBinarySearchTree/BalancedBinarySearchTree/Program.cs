using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BalancedBinarySearchTree.BinarySTBalanced;

namespace BalancedBinarySearchTree
{
     

    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> b = new BinaryTree<int>();

            b.Insert(5);
            b.Insert(4);
            b.Insert(3);
            b.Insert(2);
            b.Insert(1);
            b.Insert(7);
            b.Insert(6);
            b.Insert(8);
            b.Insert(9);
            b.Insert(10);

            b.BalanceTree();

            Console.WriteLine();
            Console.Write("Breadth First Traversal:");
            foreach (BinaryTreeNode<int> node in b.BreadthFirstTraversal())
            {
                Console.Write(node.Data + " ");
            }

            b.BalanceTree();
            b.Delete(6, true);

            Console.WriteLine();
            Console.Write("Breadth First Traversal:");
            foreach (BinaryTreeNode<int> node in b.BreadthFirstTraversal())
            {
                Console.Write(node.Data + " ");
            }

         Console.ReadLine();
        }
    }
}
