using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.Tree
{
    public class BTreeEasy
    {
        public TreeNode Root;

        public BTreeEasy()
        {
            Root = null;
        }

        private int CalculateHeight(TreeNode node)
        {
            if (node == null)
            {
                return -1;
            }

            int leftHeight = CalculateHeight(node.left);
            int rightHeight = CalculateHeight(node.right);

            return Math.Max(leftHeight, rightHeight) + 1;
        }


        public int GetHeight()
        {
            return CalculateHeight(Root);
        }
    }

}
