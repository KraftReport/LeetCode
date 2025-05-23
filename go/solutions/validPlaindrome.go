package solutions

import (
	"strings"
	"regexp" 
)

func ValidPlaindromeSolution(s string)bool {
	
	pattern := regexp.MustCompile(`[^a-zA-Z0-9]+`)
	
	trimOutResult := pattern.ReplaceAllString(s,"") 

	trimOutResult = strings.ToLower(trimOutResult)

	for i := 0 ; i < len(trimOutResult)/2  ; i++ {
	
		if(trimOutResult[i] != trimOutResult[len(trimOutResult)-(i+1)]){ return false }
		
	}

	return true
}