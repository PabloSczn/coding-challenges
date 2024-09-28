'''
Given the root of a binary tree, return all root-to-leaf paths in any order.
A leaf is a node with no children.

Example 1:
Input: root = [1,2,3,null,5]
Output: ["1->2->5","1->3"]

Example 2:
Input: root = [1]
Output: ["1"]
'''

# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def binaryTreePaths(self, root: Optional[TreeNode]) -> List[str]: # type: ignore
        def preorder_traversal(node, path, paths):
            if node:
                # Add current node to the path
                path += str(node.val)
                
                if not node.left and not node.right:
                    paths.append(path)
                else:
                    path += "->"
                    preorder_traversal(node.left, path, paths)
                    preorder_traversal(node.right, path, paths)
        
        paths = []
        preorder_traversal(root, "", paths)
        return paths