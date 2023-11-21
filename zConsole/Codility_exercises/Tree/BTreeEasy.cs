using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.Tree
{
    public class BTreeEasy
    {
        public Tree Root;

        public BTreeEasy()
        {
            Root = null;
        }

        private int CalculateHeight(Tree node)
        {
            if (node == null)
            {
                return -1;
            }

            int leftHeight = CalculateHeight(node.l);
            int rightHeight = CalculateHeight(node.r);

            return Math.Max(leftHeight, rightHeight) + 1;
        }


        public int GetHeight()
        {
            return CalculateHeight(Root);
        }
    }

    public class Tree
    {
        public int x;
        public Tree l;
        public Tree r;
    };
}
