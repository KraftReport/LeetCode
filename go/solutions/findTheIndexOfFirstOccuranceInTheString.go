package solutions

import "fmt"

func FindTheIndexOfFirstOccuranceIntheString(haystack string,needle string) int {
	
	lengthOfNeedle := len(needle)
	
	lenghtOfHaystack := len(haystack)
	
	result := []int{}

	for i := 0 ; i < lenghtOfHaystack ; i++ {

		endIndex := i + lengthOfNeedle 

		if endIndex <= lenghtOfHaystack {

			subString := haystack[i:endIndex] 

			if subString == needle {

				result = append(result,i)
			}
		}
	}

	if(len(result) > 0 ){ return result[0] }

	return -1
}