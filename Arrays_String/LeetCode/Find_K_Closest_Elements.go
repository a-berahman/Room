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
		if arr[mid] == x {
			return mid
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
	}

	high := func() int {
		if arr[len(arr)-1] < index+k-1 {
			return arr[len(arr)-1]
		}
		return index + k - 1
	}

	//min, max := GetMinAndMax(arr)

}

func GetMinAndMax(arr []int) (int, int) {
	if len(arr) < 1 {
		log.Fatal("input length must be more than 0")
	}
	min := arr[0]
	max := arr[0]
	for _, value := range arr {
		if value < min {
			min = value
		}
		if value > max {
			max = value
		}
	}
	return min, max
}