package solutions 

import (
	"fmt"
	"reflect"
)

func IsomorphicStringsSolution(s string,t string)bool{

	dataMap := make(map[string]int)

	sSlice := []int{}

	tSlice := []int{}

	if len(s) != len(t) { return false }

	for i := 0 ; i < len(s) ; i++ {
		
		if _,ok := dataMap["s"+string(s[i])] ; ok { 
			sSlice = append(sSlice,dataMap["s"+string(s[i])]) 
		}else{
			sSlice = append(sSlice,i)
			dataMap["s"+string(s[i])] = i
		}

		if _,ok := dataMap["t"+string(t[i])] ; ok { 
			tSlice = append(tSlice,dataMap["t"+string(t[i])]) 
		}else{
			tSlice = append(tSlice,i)
			dataMap["t"+string(t[i])] = i
		}

	}

	fmt.Println(dataMap)

	fmt.Println(sSlice)
	fmt.Println(tSlice)

	return reflect.DeepEqual(sSlice,tSlice)
}