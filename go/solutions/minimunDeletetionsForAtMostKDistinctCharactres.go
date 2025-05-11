package solutions

import "sort"

type kv struct {
	key   rune
	value int
}

func MinimunDeletionsForAtMostKDistinctCharacters(s string,k int)int{
	dataMap := make(map[rune]int)
	index := 0
	result := 0

	for _,value := range s {
		if val,ok := dataMap[value]; ok {
			dataMap[value] = val + 1
		}else{
			dataMap[value] = 1
		}
	}

	distinctCharacterCount := len(dataMap)

	var sorted []kv
	for k,v := range dataMap{
		sorted = append(sorted,kv{k,v})
	}

	sort.Slice(sorted,func(i,j int)bool{
		return sorted[i].value < sorted[j].value
	})

	for distinctCharacterCount > k {
		result = result + sorted[index].value
		index++
		distinctCharacterCount--
	}

	return result 
}