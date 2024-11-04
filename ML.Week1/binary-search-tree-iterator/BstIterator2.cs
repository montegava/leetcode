using Week1.common;

namespace Week1.construct_binary_tree_from_preorder_and_inorder_traversal;

public class BstIterator2
{
    private Stack<TreeNode> stack = new Stack<TreeNode>();
    
    public BstIterator2(TreeNode root)
    {
        Left(root);
    }

    private void Left(TreeNode n)
    {
        while (n != null)
        {
            stack.Push(n);
            n = n.left;
        }
    }

    public int Next()
    {
        var n = stack.Pop();

        if (n.right != null)
        {
            Left(n.right);
        }

        var result = n.val;
        Console.Write(result + ", ");
        
        return result;
    }

    public bool HasNext()
    {
        var result = stack.Count > 0;
        Console.Write(result + ", ");
        return result;
    }
}