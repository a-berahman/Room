

	type ListNode struct {
		Val  int
		Next *ListNode
	}

	func getIntersectionNode(headA, headB *ListNode) *ListNode {

		if headA == nil || headB == nil {
			return nil
		}

		first := headA
		second := headB

		for first != second {

			first = first.Next
			second = second.Next

			if first == second {
				return first
			}

			if first == nil {
				first = headB
			}
			if second == nil {
				second = headA
			}

		}
		return first

	}