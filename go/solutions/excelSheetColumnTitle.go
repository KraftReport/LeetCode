package solutions 

func ExcelSheetColumnTitleSolution(columnNumber int)string{

	result := ""

	for columnNumber > 0 {
		
		columnNumber--

		data := columnNumber  % 26
		
		letter := string(rune(data+65))  
		
		result = letter + result

		columnNumber /= 26
	
	}

	return result

}