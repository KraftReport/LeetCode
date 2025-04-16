package solutions

func MaxConsecutiveOnesSolution(nums []int) int {
	combo := 0
	max := 0
	for _ , num := range nums{
		if(num == 0){ combo = 0 }
		if(num == 1){ combo++ }
		if(combo > max) { max = combo }
	}
	return max
}