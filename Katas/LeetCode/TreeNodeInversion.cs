public class TreeNodeInversion
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null)
            return null;

        (root.Left, root.Right) = (root.Right, root.Left);
        InvertTree(root.Left);
        InvertTree(root.Right);

        return root;
    }
}

public class TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
{
    public int Value = val;
    public TreeNode Left = left;
    public TreeNode Right = right;
}

