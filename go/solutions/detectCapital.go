package solutions

func DetectCapitalSolution(word string)bool{

	if len(word) >= 2 && word[0] >= 'A' && word[0] <= 'Z' && word[1] >= 'a' && word[1] <= 'z'{
		for i := 2 ; i < len(word) ; i++{
			if word[i] >= 'A' && word[i] <= 'Z'{
				return  false
			}
		} 
	}else{
		if  word[0] >= 'a' && word[0] <= 'z'  {
			for _,character := range word{
				if character >= 'A' && character <= 'Z'{
					return false
				}
			}
		}
		if  word[0] >= 'A' && word[0] <= 'Z'  {
			for _,character := range word{
				if character >= 'a' && character <= 'z'{
					return false
				}
			}
		}
	
	}
  
	return true
}