using Week1.common;

namespace Week1.construct_binary_tree_from_preorder_and_inorder_traversal;

public class Solution2
{
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {

        var index = 0;
        var dic = new Dictionary<int, int>();
        for (var i = 0; i < inorder.Length; i++)
        {
            dic[inorder[i]] = i;
        }
        var pindex = 0;

        TreeNode dfs(int l, int r)
        {
            if (l > r)
            {
                return null;
            }

            var n = new TreeNode(preorder[pindex]);
            var rootIndex = dic[preorder[pindex]];
            pindex = pindex + 1;
            n.left = dfs(l, rootIndex - 1);
            n.right = dfs(rootIndex + 1, r);

           
            return n;
        }

        return dfs(0, preorder.Length-1);
    }
}