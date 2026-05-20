// 530. Minimum Absolute Difference in BST
// Given the root of a Binary Search Tree (BST), return the minimum absolute difference between the values of any 
// two different nodes in the tree.

// Definition for a binary tree node.
class TreeNode {
    int val;
    TreeNode left;
    TreeNode right;
    TreeNode() {}
    TreeNode(int val) { this.val = val; }
    TreeNode(int val, TreeNode left, TreeNode right) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

class Solution {
    TreeNode prev = null;
    int output = Integer.MAX_VALUE;
    public void DFS(TreeNode root) {            
        if (root.left != null) {
            DFS(root.left);                
        }   
        if (prev != null) {
            output = Math.min(output, root.val - prev.val);
        }            
        prev = root;
        if (root.right != null) {
            DFS(root.right);
        }              
    }
        
    public int getMinimumDifference(TreeNode root) {
        DFS(root); 
        return output;
    }

    public static void main(String[] args) {
        Solution solution = new Solution();
        TreeNode root = new TreeNode(1, null, new TreeNode(3));
        System.out.println(solution.getMinimumDifference(root)); // 2
    }
}
