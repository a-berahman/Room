func searchRange(nums []int, target int) []int {
    res:=[]int{-1,-1}
    leftIndex:=findIndex(nums,target,true)
    if leftIndex>=len(nums) || nums[leftIndex]!=target { return res }
    res[0]=leftIndex
    rightIndex:=findIndex(nums,target,false)
    res[1]=rightIndex-1
    return res


}
func findIndex(nums []int, target int,isLeft bool) int{
    left:=0
    right:=len(nums)
    for left<right{
        mid:=left+(right-left)/2
        
        if nums[mid]>target || (isLeft && nums[mid]==target) {
            right=mid
        } else {left=mid+1}
    }
    return left
}