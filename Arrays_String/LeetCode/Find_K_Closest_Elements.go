func findClosestElements(arr []int, k int, x int) []int {

	if x <= arr[0] {
		return arr[:k]
	}
	if x >= arr[len(arr)-1] {
		return arr[len(arr)-k:]
	}

	index := func() int {
		left := 0
		right := len(arr) - 1
		for left < right {
			mid := left + (right-left)/2
			if arr[mid] == x {
				return mid
			} else if arr[mid] > x {
				right = mid
			} else {
				left = mid + 1
			}
		}

		return left
	}()
	if index < 0 {
		index = -index - 1
	}

	low := func() int {
		if index-k-1 > 0 {
			return index - k - 1
		}
		return 0
	}()

	high := func() int {
		if len(arr)-1 < index+k-1 {
			return len(arr) - 1
		}
		return index + k - 1
	}()

	for high-low > k-1 {
		if low < 0 || (x-arr[low]) <= (arr[high]-x) {
			high--
		} else if high > len(arr)-1 || (x-arr[low]) > (arr[high]-x) {
			low++
		}
	}
	return arr[low : high+1]

}