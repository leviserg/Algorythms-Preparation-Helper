using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.Tree
{
    public static class Compare2Trees
    {
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            /* Compact version:
                if (p == null || q == null) {
                    return p == q;
                }
                return (p.val == q.val) & IsSameTree(p.left, q.left) & IsSameTree(p.right, q.right);
             */
            /*
             
             */
            if (p == null && q == null)
            {
                return true;
            }
            if (p != null && q != null)
            {
                bool isLeftEqual = IsSameTree(p.left, q.left);
                bool isValEqual = (p.val == q.val);
                bool isRightEqual = IsSameTree(p.right, q.right);
                return isLeftEqual & isValEqual & isRightEqual;
            }
            return false;
            /*
             using BFS (Queue based) instead of recursion - BTW: the same is possible using Stack
             // Create queues for both trees.
                Queue<TreeNode> queue1 = new Queue<TreeNode>();
                Queue<TreeNode> queue2 = new Queue<TreeNode>();

                // Start by adding the root nodes of both trees to their respective queues.
                queue1.Enqueue(p);
                queue2.Enqueue(q);

                while (queue1.Count > 0 && queue2.Count > 0) {
                    TreeNode node1 = queue1.Dequeue();
                    TreeNode node2 = queue2.Dequeue();

                    // If the values of the current nodes are not equal, the trees are not identical.
                    if (node1 == null && node2 == null) {
                        continue;
                    }
                    if (node1 == null || node2 == null || node1.val != node2.val) {
                        return false;
                    }

                    // Add the left and right children of both nodes to their respective queues.
                    queue1.Enqueue(node1.left);
                    queue1.Enqueue(node1.right);
                    queue2.Enqueue(node2.left);
                    queue2.Enqueue(node2.right);
                }

                // If both queues are empty, the trees are identical.
                return queue1.Count == 0 && queue2.Count == 0;
             */
        }

        public static bool IsSymmetric(TreeNode root)
        {
            if (root is null)
            {
                return true;
            }
            return IsBranchSymmetric(root.left, root.right);
        }

        private static bool IsBranchSymmetric(TreeNode l, TreeNode r)
        {
            if (l is null && r is null)
            {
                return true;
            }
            if (l is null || r is null)
            {
                return false;
            }
            return (l.val == r.val) & IsBranchSymmetric(l.left, r.right) & IsBranchSymmetric(l.right, r.left);
        }
    }
}
