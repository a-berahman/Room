func mySqrt(x int) int{
	res:=x;
	for res*res-x>=1{
		res=(res+x/res)/2
	}
	return res
}