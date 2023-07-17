using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_BST
{
    internal class BinaryTree
    {
        public Node root;


        public Node buildTree(int[] arr, int start, int end)
        {

            if (start > end)
            {
                return null;
            }


            int mid = (start + end) / 2;
            Node node = new Node(arr[mid]);


            node.left = buildTree(arr, start, mid - 1);
            node.right = buildTree(arr, mid + 1, end);



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
