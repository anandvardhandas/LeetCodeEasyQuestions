/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        IList<int> result = new List<int>();
        Helper(result, root);
        return result;
    }
    
    private void Helper(IList<int> result, TreeNode root)
    {
        if(root == null)
            return;
        
        result.Add(root.val);
        Helper(result, root.left);
        Helper(result, root.right);
    }
}
