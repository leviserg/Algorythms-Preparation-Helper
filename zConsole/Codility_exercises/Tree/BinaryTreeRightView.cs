using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.Tree
{
    public static class BinaryTreeRightView
    {
        public static IList<int> RightSideView(TreeNode root)
        {
            List<int> result = new List<int>();
            if (root == null) return result;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Any())
            {
                int size = q.Count();
                for (int i = 0; i < size; i++)
                {
                    TreeNode node = q.Dequeue();
                    if (i == size - 1) { result.Add(node.val); }
                    if (node.left != null) { q.Enqueue(node.left); }
                    if (node.right != null) { q.Enqueue(node.right); }
                }
            }
            return result;
        }
    }
}
