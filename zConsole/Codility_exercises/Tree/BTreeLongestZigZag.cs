using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.Tree
{
    public class BTreeLongestZigZag
    {
        public TreeNode Root;

        public BTreeLongestZigZag(TreeNode root)
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

        private ZigZagResult LongestZigZagPathRecursive(TreeNode node)
        {
            if (node == null)
            {
                return new ZigZagResult(0);
            }

            // Recursively calculate the longest zigzag path for the left and right subtrees
            ZigZagResult leftResult = LongestZigZagPathRecursive(node.left);
            ZigZagResult rightResult = LongestZigZagPathRecursive(node.right);

            // Initialize the maximum zigzag lengths for the current node
            int leftMax = 1;
            int rightMax = 1;

            // Update the maximum zigzag lengths based on the left and right subtrees
            if (node.left != null)
            {
                leftMax = 1 + rightResult.MaxZigZagLength;
            }
            if (node.right != null)
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
