package LinkedList

func main() {

}

type ListNode struct {
	Val  int
	Next *ListNode
}

func mergeTwoLists(l1 *ListNode, l2 *ListNode) *ListNode {
	if l1 == nil {
		return l2
	}
	if l2 == nil {
		return l1
	}

	main := &ListNode{Val: -1, Next: nil}
	head := main

	for l1 != nil && l2 != nil {
		if l1.Val < l2.Val {
			head.Next = l1
			l1 = l1.Next
		} else {
			head.Next = l2
			l2 = l2.Next
		}
		head = head.Next

	}

	if l1 == nil {
		head.Next = l2
	} else {
		head.Next = l1
	}

	return main.Next

}
