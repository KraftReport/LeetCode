package solutions

import "strings"

func MostFrequentVowelAndConsonantSolution(s string)int{
	vowels := "aeiou"
	vowelMap := make(map[rune]int)
	consonantMap := make(map[rune]int)
	mostVowelCount := 0
	mostConsonantCount := 0

	for _,value := range s {
		if strings.ContainsRune(vowels,rune(value)){
			if val,ok := vowelMap[value] ; ok {
				val = val+1
				vowelMap[value] = val
				if val > mostVowelCount {
					mostVowelCount = val
				}
			}else{
				vowelMap[value] = 1
				if vowelMap[value] > mostVowelCount {
					mostVowelCount = vowelMap[value]
				}
			}
		}else{
			if val,ok := consonantMap[value] ; ok {
				val = val+1
				consonantMap[value] = val
				if val > mostConsonantCount {
					mostConsonantCount = val
				}
			}else{
				consonantMap[value] = 1
				if consonantMap[value] > mostConsonantCount{
					mostConsonantCount = consonantMap[value]
				}
			}
		}
	}

	return mostConsonantCount + mostVowelCount

}