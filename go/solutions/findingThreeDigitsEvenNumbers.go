package solutions

import (
	"strconv"
		"sort"
)

func FindingThreeDigitsEvenNumbers(digits []int)[]int{
	result := []int{}
	dataMap := make(map[int]int)
	for i := 0 ; i < len(digits) ; i++{
		for j := 0 ; j < len(digits) ; j++{
			if j == i {continue}
			for k := 0 ; k < len(digits) ; k++{
				if k == j || k == i {continue} 
				box := digits[i]*100 + digits[j] * 10 + digits[k] 
				if _,ok := dataMap[box]; !ok{
					dataMap[box] = 1
					if len(strconv.Itoa(box)) == 3 {
						if box % 2 == 0 {
							result = append(result,box)
						}
					} 
				} 
				} 
			}
		}
		sort.Ints(result)
		return result
}