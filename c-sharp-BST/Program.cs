using c_sharp_BST;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = { 7, 5, 3, 10, 9, 20, 2, 4 };
        BinaryTree tree = new BinaryTree();
        tree.root = tree.buildTree(arr, 0, arr.Length - 1);

        Console.WriteLine("In-order traversal:");
        tree.InOrderTraversal(tree.root);

    }
}