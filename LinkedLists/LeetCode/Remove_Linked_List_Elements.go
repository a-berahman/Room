package LinkedList

type ListNode struct {
	Val  int
	Next *ListNode
}

func removeElements(head *ListNode, val int) *ListNode {
	dummy := &ListNode{Val: 0}
	dummy.Next = head
	tracker := dummy
	for tracker.Next != nil {
		if tracker.Next.Val == val {
			next := tracker.Next
			tracker.Next = next.Next
		} else {
			tracker = tracker.Next
		}

	}
	return dummy.Next
}
