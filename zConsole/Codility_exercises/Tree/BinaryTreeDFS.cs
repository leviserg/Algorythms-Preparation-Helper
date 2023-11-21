using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.Tree
{
    public class BinaryTreeDFS
    {
        public void DFS(TreeNode root)
        {
            if (root == null)
                return;

            Console.WriteLine(root.val); // Process the current node

            DFS(root.left); // Recursively visit the left subtree
            DFS(root.right); // Recursively visit the right subtree
        }
    }

    /*
     usage:

    class Program
    {
        static void Main(string[] args)
        {
            // Create a sample binary tree
            TreeNode root = new TreeNode(1);
            root.Left = new TreeNode(2);
            root.Right = new TreeNode(3);
            root.Left.Left = new TreeNode(4);
            root.Left.Right = new TreeNode(5);

            BinaryTreeDFS treeDFS = new BinaryTreeDFS();

            Console.WriteLine("Depth-First Traversal (DFS):");
            treeDFS.DFS(root);
        }
    }

    Output:
    Depth-First Traversal (DFS):
    1
    2
    4
    5
    3

     */
}
