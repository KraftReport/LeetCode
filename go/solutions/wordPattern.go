package solutions

import (
	"strings"
 
)

func WordPatternSolution(pattern string,s string)bool{
	
	trimmed := strings.TrimSpace(s)
	
	words := strings.Fields(trimmed)

	keyBag := make(map[string]string)

	valueBag := make(map[string]string)

	if len(pattern) != len(words) { return false}

	for i := 0 ; i < len(words) ; i++ {
		key , keyOk := keyBag[string(pattern[i])]
		value , valueOk := valueBag[words[i]]
		if keyOk && valueOk {
			if key !=words[i] ||  value != string(pattern[i]) {
				return false
			}
		}else if !keyOk && !valueOk {
			keyBag[string(pattern[i])] = words[i]
			valueBag[words[i]] = string(pattern[i])
		}else{
			return false
		}
	}

	return true
}