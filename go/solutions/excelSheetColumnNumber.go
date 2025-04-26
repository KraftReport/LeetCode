package solutions

import "math"

func ExcelSheetColumnNumberSolution(columnTitle string)int{
	
	result := 0

	for i := len(columnTitle) -1 ; i >= 0 ; i-- {
		
		code := int(rune(columnTitle[i]) - 64)
		
		code = code * int((math.Pow(26,float64((len(columnTitle)-1)-i))))
		
		result = code + result
	}

	return result

}