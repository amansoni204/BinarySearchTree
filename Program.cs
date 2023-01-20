using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class BinarySearchTree
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Binary SearchTree");
            BinarySearch<int> binarySearchTree = new BinarySearch<int>(56);
            binarySearchTree.AddNode(30);
            binarySearchTree.AddNode(70);
            binarySearchTree.Display();

        }
    }
}
