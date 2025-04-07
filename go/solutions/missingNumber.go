package solutions

func MissingNumberSolution(nums []int) int {
	dataBag := make(map[int]bool)
	var size = len(nums)
	for i := 0; i <= size; i++{
		dataBag[i] = true
	}
	for _,num := range nums{
		delete(dataBag,num)
	}
	for missing := range dataBag{
		return missing
	}
	return -1
}