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
        Stack<TreeNode> st = new Stack<TreeNode>();
        if(root != null)
            st.Push(root);
        
        while(st.Count > 0)
        {
            root = st.Pop();
            result.Add(root.val);
            
            if(root.right != null)
                st.Push(root.right);
            
            if(root.left != null)
                st.Push(root.left);
        }
        
        return result;
    }
}
