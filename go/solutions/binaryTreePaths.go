package solutions

import "strconv"

type TreeNode struct {
	 Val int
	 Left *TreeNode
	 Right *TreeNode
}
 

func BinaryTreePaths(root *TreeNode)[]string{
	var result = []string
	getValue(root,"",&result)
	return result
}

func getValue(root *TreeNode,s string,result *[]string){

	if root == nil {
		return
	}

	if len(s) > 0 {
		s += "->"
	}

	s += strconv.Itoa(root.Val)

	if root.Left == nil && root.Right == nil {
		*result = append(*result,s)
		return
	}

	getValue(root.Left,s,result)

	getValue(root.Right,s,result)
	
}