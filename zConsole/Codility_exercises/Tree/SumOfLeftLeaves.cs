using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.Tree
{
    public class SumOfLeftLeaves
    {
        public int GetSumOfLeftLeaves(TreeNode root)
        {
            if (root == null)
                return 0;

            int sum = 0;

            if (root.left != null)
            {
                if (IsLeave(root.left))
                {
                    sum += root.left.val;
                }
                else
                {
                    sum += GetSumOfLeftLeaves(root.left);
                }
            }
            sum += GetSumOfLeftLeaves(root.right);
            return sum;
        }

        private bool IsLeave(TreeNode node)
        {
            return node.left == null && node.right == null;
        }
    }
}
