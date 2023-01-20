﻿using System;
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
            binarySearchTree.AddNode(22);
            binarySearchTree.AddNode(44);
            binarySearchTree.AddNode(60);
            binarySearchTree.AddNode(95);
            binarySearchTree.AddNode(11);
            binarySearchTree.AddNode(65);
            binarySearchTree.AddNode(3);
            binarySearchTree.AddNode(16);
            binarySearchTree.AddNode(63);
            binarySearchTree.AddNode(67);
            binarySearchTree.Display();

        }
    }
}
