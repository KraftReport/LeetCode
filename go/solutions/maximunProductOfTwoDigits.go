package solutions

import "strconv"

func MaximunProductOfTwoDigitsSolution(n int)int{
	str := strconv.Itoa(n)
	result := int(str[0] - '0') * int(str[1]- '0')
	first := 0
	second := 1
	for first < len(str) && second < len(str) {
		product := int(str[first]-'0') * int(str[second]-'0')
		if product > result {
			result = product
		}
		if second < len(str) {
			second++ 
		}
		if second == len(str) {
			first++
			second = first + 1
		}
	} 
	return result 
}