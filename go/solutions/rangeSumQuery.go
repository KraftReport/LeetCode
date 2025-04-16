package solutions

type NumArray struct {
    numArray []int
}


func Constructor(nums []int) NumArray {
    return NumArray{
		numArray : nums,
	}
}


func (this *NumArray) SumRange(left int, right int) int {
	result := 0
    slicedList := this.numArray[left:right+1]
	for _, data := range slicedList{
		result += data
	}
	return result
}

