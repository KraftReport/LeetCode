package solutions

import "strings"

func LengthOfLastWordSolution(s string) int{
	
	data := strings.Fields(s)
	 
	index := len(data) - 1

	last := data[index]
	
	word := []rune(last)
	
	return len(word)
}