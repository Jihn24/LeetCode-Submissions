# 530. Minimum Absolute Difference in BST
# Given the root of a Binary Search Tree (BST), return the minimum absolute difference between the values of any 
# two different nodes in the tree.

# Definition for a binary tree node.
class TreeNode(object):
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

class Solution(object):
    def DFS(self, root):            
            if root.left != None:
                self.DFS(root.left)             
            if self.prev != None:
                self.output = min(self.output, root.val - self.prev.val)
            self.prev = root
            if root.right != None:
                self.DFS(root.right)

    def getMinimumDifference(self, root):
        """
        :type root: Optional[TreeNode]
        :rtype: int
        """
        self.prev = None
        self.output = 100000000000000
        self.DFS(root)
        return self.output
    
solution = Solution()
print(solution.getMinimumDifference(TreeNode(4, TreeNode(2, TreeNode(1), TreeNode(3)), TreeNode(6)))) # 1