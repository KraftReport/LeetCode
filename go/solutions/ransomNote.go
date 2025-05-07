package solutions 

func RansomNoteSolution(ransomNote string,magazine string)bool{
	dataMap := make(map[rune]int)
	for _,word := range magazine{
		if val,ok := dataMap[word]; ok {
			dataMap[word] = val+1 
		}else{
			dataMap[word] = 1
		}
	}
	for _,note := range ransomNote{
		if val,ok := dataMap[note] ; ok {
			if val > 1 {
				dataMap[note] = val -1
			}else{
				delete(dataMap,note)
			} 
		}else{
			return false
		}
	}
	return true
}