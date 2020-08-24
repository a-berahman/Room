func sortArrayByParity(A []int) []int {
	i := 0
	for j := 0; j < len(A); j++ {
		if A[j]%2 == 0 {
			temp := A[i]
			A[i] = A[j]
			A[j] = temp

			i++
		}
	}
	return A
}
