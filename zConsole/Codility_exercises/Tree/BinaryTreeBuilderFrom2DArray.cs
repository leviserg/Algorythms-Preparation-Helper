using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.Tree
{
    public class BinaryTreeBuilderFrom2DArray
    {
        public TreeNode BuildTreeFrom2DArray(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0)
                return null;

            return BuildTree(matrix, 0, 0, matrix[0].Length - 1);
        }

        private TreeNode BuildTree(int[][] matrix, int row, int left, int right)
        {
            if (row >= matrix.Length || left > right)
                return null;

            int mid = (left + right) / 2;

            if (matrix[row][mid] == 0)
                return null;

            TreeNode node = new TreeNode(matrix[row][mid]);
            node.left = BuildTree(matrix, row + 1, left, mid - 1);
            node.right = BuildTree(matrix, row + 1, mid + 1, right);

            return node;
        }
    }
}
