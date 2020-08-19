func checkIfExist(arr []int) bool {

	ls := make(map[float64]struct{})
	for _, value := range arr {
		a := float64(float64(value) / 2.0)
		if _, ok := ls[a]; ok {
			return true
		}
		if _, ok := ls[float64(value*2)]; ok {
			return true
		}
		ls[float64(value)] = struct{}{}
	}
	return false
}