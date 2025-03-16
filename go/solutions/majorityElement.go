package solutions

func MajorityElementSolution(nums []int) int {

	condidate, count := 0, 0

	for _, num := range nums {

		if count == 0 {
			condidate = num
		}

		if num == condidate {
			count++
		} else {
			count--
		}
	}

	return condidate
}
