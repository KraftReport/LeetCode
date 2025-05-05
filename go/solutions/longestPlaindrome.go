package solutions

func LongestPlaindromeSolution(s string)int{
	
	dataMap := make(map[byte]int)
	
	result := 0

	for i := 0 ; i < len(s) ; i++ {
		if _,ok := dataMap[s[i]]; ok {
			result += 2
			delete(dataMap,s[i])
		}else{
			dataMap[s[i]] = 1
		}
	}

	if len(dataMap) > 0 { result++}

	return result
}