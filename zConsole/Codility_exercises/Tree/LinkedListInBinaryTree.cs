namespace zConsole.Codility_exercises.Tree
{
    public class LinkedListInBinaryTree
    {
        public bool IsSubPath(ListNode head, TreeNode root)
        {
            if (root == null)
            {
                return false;
            }
            if (Match(head, root)) return true;
            return IsSubPath(head, root.left) || IsSubPath(head, root.right);
        }

        private bool Match(ListNode head, TreeNode root)
        {
            if (head == null) return true;
            if (root == null || root.val != head.val) return false;
            return Match(head.next, root.left) || Match(head.next, root.right);
        }
    }
}
