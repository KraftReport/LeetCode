package solutions

func FirstUniqueCharacterSolution(s string) int  {
	
	dataMap := make(map[byte]int)

	for i := 0 ; i < len(s) ; i++ {
		if val,ok := dataMap[s[i]] ; ok {
			dataMap[s[i]] = val + 1
		}else{
			dataMap[s[i]] = 1
		}
	}

	for j := 0 ; j < len(s) ; j++ {
		if val,ok := dataMap[s[j]]; ok {
			if val == 1 {
				return j
			}
		} 
	}

	return -1 

}