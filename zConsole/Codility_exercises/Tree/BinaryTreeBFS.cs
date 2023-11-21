using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.Tree
{
    public class BinaryTreeBFS
    {
        public void BFS(TreeNode root)
        {
            if (root == null)
                return;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode current = queue.Dequeue();

                Console.WriteLine(current.val); // Process the current node

                if (current.left != null)
                    queue.Enqueue(current.left);

                if (current.right != null)
                    queue.Enqueue(current.right);
            }
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

            BinaryTreeBFS treeBFS = new BinaryTreeBFS();

            Console.WriteLine("Breadth-First Traversal (BFS):");
            treeBFS.BFS(root);
        }
    }
     
    Output:
    Breadth-First Traversal (BFS):
    1
    2
    3
    4
    5
     
     */



}
