package solutions

import ( 
	"fmt"
	"strconv"
)

func AddBinarySolution(a string, b string) string {
	
	stop := false
	
	lengthOfA := len(a)
	
	lengthOfB := len(b)
	
	prefix := 0
	
	result := ""
	
	for !stop {
		
		aString := "0"
		
		bString := "0"
		
		if lengthOfA > 0 { aString = string(a[lengthOfA-1]) }
		
		if lengthOfB > 0 { bString = string(b[lengthOfB-1]) }
		
		
		aInt , aError := strconv.Atoi(aString)
		
		bInt , bError := strconv.Atoi(bString)

		if aError != nil || bError != nil {
		
			fmt.Println(aError)
		
			fmt.Println(bError)
		
		}else{
		
			sum := aInt + bInt + prefix
			
			switch sum {
	
			case 1:
				result = "1" + result
				prefix = 0
	
			case 2:
				result = "0" + result
				prefix = 1
	
			case 3:
				result = "1" + result
				prefix = 1

			case 0:
				result = "0" + result
				prefix = 0
	
			default: 

			}

			if lengthOfA > 0 { lengthOfA--}
	
			if lengthOfB > 0 { lengthOfB-- }

			if lengthOfA == 0 && lengthOfB == 0 { stop = true }
		
		}

	} 
	
	if prefix != 0 { result = "1"+result }

	return result
}