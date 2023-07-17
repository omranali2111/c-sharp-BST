﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_BST
{
    internal class BinaryTree
    {
        public Node root;


        public void Insert(int value)
        {
            root = InsertNode(root, value);
        }

        private Node InsertNode(Node node, int value)
        {
            if (node == null)
            {
                // Create a new node if the current node is null
                return new Node(value);
            }

            // Recursively insert the value in the left or right subtree
            if (value < node.data)
            {
                node.left = InsertNode(node.left, value);
            }
            else if (value > node.data)
            {
                node.right = InsertNode(node.right, value);
            }

            // Return the updated node
            return node;
        }



        public void InOrderTraversal(Node node)
        {
            if (node == null)
                return;

            InOrderTraversal(node.left);
            Console.Write(node.data + " ");
            InOrderTraversal(node.right);
        }
    }
}
