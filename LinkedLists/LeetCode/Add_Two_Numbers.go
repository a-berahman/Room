package AddTwoLinkedList

type ListNode struct {
	Val  int
	Next *ListNode
}

func addTwoNumbers(l1 *ListNode, l2 *ListNode) *ListNode {
	main := &ListNode{Val: -1}
	head := main
	carry := 0
	for l1 != nil || l2 != nil {
		v1 := 0
		if l1 != nil {
			v1 = l1.Val
		}
		v2 := 0
		if l2 != nil {
			v2 = l2.Val
		}

		sum := v1 + v2 + carry
		carry = sum / 10
		head.Next = &ListNode{Val: sum % 10}
		head = head.Next

		if l1 != nil {
			l1 = l1.Next
		}

		if l2 != nil {
			l2 = l2.Next
		}
	}

	if carry > 0 {
		head.Next = &ListNode{Val: carry}
	}
	return main.Next

}
