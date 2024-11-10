using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ML.Common.common;
using Week1.common;

namespace ML.Week4.delete_node_in_a_bst
{
    public class Solution
    {
        public TreeNode DeleteNode(TreeNode root, int key)
        {

            (TreeNode d, TreeNode p) dfs(TreeNode n, TreeNode p)
            {
                if (n == null)
                    return (null, null);

                if (n.val == key)
                    return (n, p);

                if (n.val > key)
                    return dfs(n.left, n);

                return dfs(n.right, n);
            }

            void dfs2(TreeNode parent, TreeNode attach)
            {
                if (parent == null || attach == null)
                    return;

                if (parent.val > attach.val)
                {
                    if (parent.left == null)
                    {
                        parent.left = attach;
                        return;
                    }
                    else
                    {
                        dfs2(parent.left, attach);
                    }
                }
                if (parent.val < attach.val)
                {
                    if (parent.right == null)
                    {
                        parent.right = attach;
                        return;
                    }
                    else
                    {
                        dfs2(parent.right, attach);
                    }
                }

            }


            var res = dfs(root, null);

            if (res.d == null)
                return root;

            if (res.p == null)
            {
                if (res.d.right != null)
                {
                    dfs2(res.d.right, res.d.left);
                    return res.d.right;
                }
                else
                {
                    dfs2(res.d.left, res.d.right);
                    return res.d.left;
                }
            }
            else
            {
                if (res.p.right == res.d)
                {
                    if (res.d.right != null)
                    {
                        res.p.right = res.d.right;
                        dfs2(res.d.right, res.d.left);
                    }
                    else
                    {
                        res.p.right = res.d.left;
                        dfs2(res.d.right, res.d.right);
                    }
                }
                else
                {
                    if (res.d.left != null)
                    {
                        res.p.left = res.d.left;
                        dfs2(res.d.left, res.d.right);
                    }
                    else
                    {
                        res.p.left = res.d.right;
                        dfs2(res.d.left, res.d.left);
                    }
                }

            }

            return root;
        }
    }
}
