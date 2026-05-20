// 530. Minimum Absolute Difference in BST
// Given the root of a Binary Search Tree (BST), return the minimum absolute difference between the values of any 
// two different nodes in the tree.

namespace MinAbsInBST {
    class Program {
        static void Main(string[] args)
        {
            var solution = new Solution();
            var result = solution.GetMinimumDifference(new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(6)));
            Console.WriteLine(result);
        }
    }

    // Second attempt, O(n) time and O(1) space because we are not storing the values of the nodes in a list, we are just keeping track of the previous node and the minimum difference.
    class Solution {
        TreeNode prev = null;
        int output = Int32.MaxValue;
        public void DFS(TreeNode root) {
            
            if (root.left != null) {
                DFS(root.left);                
            }   
            if (prev != null) {
                output = Math.Min(output, root.val - prev.val);
            }            
            prev = root;
            if (root.right != null) {
                DFS(root.right);
            }              
        }
        
        public int GetMinimumDifference(TreeNode root) {
            DFS(root); 
            return output;
        }
    }

    // First attempt, O(n) time and O(n) space because we are storing the values of the nodes in a list and then sorting the list to find the minimum difference.
    // class Solution {        
    //     public List<int> DFS(TreeNode root, List<int> stored) {
    //         stored.Add(root.val);

    //         if (root.left != null) {
    //             DFS(root.left, stored);
    //         }   

    //         if (root.right != null) {
    //             DFS(root.right, stored);
    //         }  
    //         return stored;
    //     }
            
    //     public int GetMinimumDifference(TreeNode root) {
            
    //         var list = new List<int>();      
    //         var stored = DFS(root, list);
    //         stored.Sort();
    //         int output = stored[1] - stored[0];  
    //         for (int i = 0; i < stored.Count() - 1; i++) {
    //             output = Math.Min(output, stored[i + 1] - stored[i]);
    //         }       

    //         return output;
    //     }
    // }

    // Definition for a binary tree node.
    class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}