package LinkedLists

type ListNode struct {
	Val  int
	Next *ListNode
}

func removeNthFromEnd(head *ListNode, n int) *ListNode {
	if head == nil {
		return head
	}
	dummy := ListNode{Val: 0, Next: head}
	length := 0

	first := head
	for first != nil {
		length += 1
		first = first.Next
	}
	length -= n
	first = &dummy
	for length > 0 {
		length -= 1
		first = first.Next
	}
	first.Next = first.Next.Next
	return dummy.Next

}
