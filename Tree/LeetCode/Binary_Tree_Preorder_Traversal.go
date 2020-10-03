package leetCode

type TreeNode struct {
	Val   int
	Left  *TreeNode
	Right *TreeNode
}
type Stack struct {
	items []*TreeNode
}

func preorderTraversal(root *TreeNode) []int {
	var stk Stack
	res := []int{}
	for root != nil || !stk.IsEmpty() {
		for root != nil {
			res = append(res, root.Val)
			stk.Push(root)
			root = root.Left
		}
		root = stk.Pop()

		root = root.Right
	}
	return res
}

func (s *Stack) IsEmpty() bool {
	return len(s.items) == 0
}
func (s *Stack) Push(t *TreeNode) {
	s.items = append(s.items, t)
}
func (s *Stack) Pop() *TreeNode {
	if len(s.items) == 0 {
		return nil
	}
	res := s.items[len(s.items)-1]
	s.items = s.items[:len(s.items)-1]
	return res
}
