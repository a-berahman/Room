package LinkedList

type ListNode struct {
	Val  int
	Next *ListNode
}

func isPalindrome(head *ListNode) bool {
	fast := head
	slow := head
	for fast != nil && fast.Next != nil {
		fast = fast.Next.Next
		slow = slow.Next
	}
	cur := slow
	var prev *ListNode
	for cur != nil {
		temp := cur.Next
		cur.Next = prev
		prev = cur
		cur = temp
	}

	for prev != nil && head != nil {
		if prev.Val == head.Val {
			prev = prev.Next
			head = head.Next

		} else {
			return false
		}

	}

	return true

}
