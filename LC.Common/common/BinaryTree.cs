namespace Week1.common;

public class BinaryTree
{
    public static TreeNode BuildTree(int?[] arr)
    {
        if (arr == null || arr.Length == 0) return null;

        TreeNode root = new TreeNode(arr[0].Value);
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int i = 1;

        while (i < arr.Length)
        {
            TreeNode current = queue.Dequeue();

            // Process the left child
            if (i < arr.Length && arr[i] != null)
            {
                current.left = new TreeNode(arr[i].Value);
                queue.Enqueue(current.left);
            }
            i++;

            // Process the right child
            if (i < arr.Length && arr[i] != null)
            {
                current.right = new TreeNode(arr[i].Value);
                queue.Enqueue(current.right);
            }
            i++;
        }

        return root;
    }
}