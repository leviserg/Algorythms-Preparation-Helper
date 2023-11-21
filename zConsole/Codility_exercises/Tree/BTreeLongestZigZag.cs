using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.Tree
{
    public class BTreeLongestZigZag
    {
        public Tree Root;

        public BTreeLongestZigZag(Tree root)
        {
            Root = root;
        }

        public int LongestZigZagPath()
        {
            if (Root == null)
            {
                return 0;
            }

            ZigZagResult result = LongestZigZagPathRecursive(Root);

            return result.MaxZigZagLength;
        }

        private ZigZagResult LongestZigZagPathRecursive(Tree node)
        {
            if (node == null)
            {
                return new ZigZagResult(0);
            }

            // Recursively calculate the longest zigzag path for the left and right subtrees
            ZigZagResult leftResult = LongestZigZagPathRecursive(node.l);
            ZigZagResult rightResult = LongestZigZagPathRecursive(node.r);

            // Initialize the maximum zigzag lengths for the current node
            int leftMax = 1;
            int rightMax = 1;

            // Update the maximum zigzag lengths based on the left and right subtrees
            if (node.l != null)
            {
                leftMax = 1 + rightResult.MaxZigZagLength;
            }
            if (node.r != null)
            {
                rightMax = 1 + leftResult.MaxZigZagLength;
            }

            // Calculate the maximum zigzag path length for the current node
            int maxZigZagLength = Math.Max(leftMax, rightMax);

            // Return the result for the current node
            return new ZigZagResult(maxZigZagLength);
        }
    }

    public class ZigZagResult
    {
        public int MaxZigZagLength;
        public ZigZagResult(int maxZigZagLength)
        {
            MaxZigZagLength = maxZigZagLength;
        }
    }
}
