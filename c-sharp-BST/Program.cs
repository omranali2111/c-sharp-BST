﻿using c_sharp_BST;

using System;

class Program
{
    static void Main(string[] args)
    {
        BinaryTree tree = new BinaryTree();
        tree.Insert(7);
        tree.Insert(5);
        tree.Insert(3);
        tree.Insert(10);
        tree.Insert(9);
        tree.Insert(20);
        tree.Insert(2);
        tree.Insert(4);

        tree.InOrderTraversal(tree.root);

    }
}
