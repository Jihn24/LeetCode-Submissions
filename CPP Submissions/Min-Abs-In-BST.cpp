// 530. Minimum Absolute Difference in BST
// Given the root of a Binary Search Tree (BST), return the minimum absolute difference between the values of any 
// two different nodes in the tree.

// Definition for a binary tree node.
struct TreeNode {
    int val;
    TreeNode *left;
    TreeNode *right;
    TreeNode() : val(0), left(nullptr), right(nullptr) {}
    TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
    TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
};

class Solution {
public:
    TreeNode *prev = nullptr;
    int output = INT_MAX;
    void DFS(TreeNode* root) {
            
        if (root->left != nullptr) {
            DFS(root->left);                
        }   
        if (prev != nullptr) {
            output = min(output, root->val - prev -> val);
        }            
        prev = root;
        if (root->right != nullptr) {
            DFS(root->right);
        }              
    }
    
    int getMinimumDifference(TreeNode* root) {
        DFS(root); 
        return output;
    }
};