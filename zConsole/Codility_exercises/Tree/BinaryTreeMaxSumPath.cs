using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.Tree
{
    public class BinaryTreeMaxSumPath
    {

        private int max = int.MinValue;

        public int GetMaxSum(TreeNode root)
        {
            PostOrderTree(root);
            return max;
        }


        private int PostOrderTree(TreeNode root)
        {
            if (root == null)
                return 0;
            int left =  Math.Max(PostOrderTree(root.left),0); // replace negative number with 0 to avoid max calc. inversion
            int right = Math.Max(PostOrderTree(root.right),0);
            max = Math.Max(max,left + right + root.val); // (left,0 if negative) + (right,0) + root.val
            return Math.Max(left,right) + root.val;
        }
    }
}
