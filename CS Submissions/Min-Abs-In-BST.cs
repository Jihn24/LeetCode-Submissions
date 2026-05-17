// 530. Minimum Absolute Difference in BST
// Given the root of a Binary Search Tree (BST), return the minimum absolute difference between the values of any 
// two different nodes in the tree.

var solution = new Solution();
var result = solution.GetMinimumDifference(new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(6)));
Console.WriteLine(result);

public class Solution {
    
    public List<int> DFS(TreeNode root, List<int> stored) {
            stored.Add(root.val);

            if (root.left != null) {
                DFS(root.left, stored);
            }   

            if (root.right != null) {
                DFS(root.right, stored);
            }  
            return stored;
        }
        
    public int GetMinimumDifference(TreeNode root) {
        
        var list = new List<int>();      
        var stored = DFS(root, list);
        stored.Sort();
        int output = stored[1] - stored[0];  
        for (int i = 0; i < stored.Count() - 1; i++) {
            output = Math.Min(output, stored[i + 1] - stored[i]);
        }       

        return output;
    }
}

// Definition for a binary tree node.
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}