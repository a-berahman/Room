package LeetCode

//Definition for singly-linked list.
type ListNode struct {
	Val  int
	Next *ListNode
}

func hasCycle(head *ListNode) bool {

	if head == nil {
		return false
	}
	slow := head
	fast := head.Next

	for fast != slow {

		if fast == nil || fast.Next == nil || fast.Next.Next == nil {
			return false
		}

		fast = fast.Next.Next
		slow = slow.Next
	}
	return true

}
