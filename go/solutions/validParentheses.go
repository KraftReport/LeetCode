package solutions
 

func ValidParenthesesSolution(s string)bool{
	
	dataMap := map[rune]int{
		'{' : 0 , '(' : 0 , '[' : 0,
	}

	brackets := []rune(s)

	lastOpenBracketIndexs := []int{}

	tick := 0

	if(len(brackets) < 2){
		return false
	}

	for i := 0 ; i < len(brackets) ; i++ {
		if(brackets[i] == '{' || brackets[i] == '(' || brackets[i] == '['){
			dataMap[brackets[i]] = dataMap[brackets[i]] + 1
			lastOpenBracketIndexs = append(lastOpenBracketIndexs,i)
			tick++
		}
		if(brackets[i] == '}' || brackets[i] == ')' || brackets[i] == ']'){

			tick++

			closeBracket := '{'

			if(brackets[i] == ')') { closeBracket = '(' }
			
			if(brackets[i] == ']') { closeBracket = '[' }

			if(len(lastOpenBracketIndexs) > 0 ){
				if(brackets[lastOpenBracketIndexs[len(lastOpenBracketIndexs)-1]] == closeBracket){
					dataMap[closeBracket] = dataMap[closeBracket] - 1
					lastOpenBracketIndexs = lastOpenBracketIndexs[:len(lastOpenBracketIndexs)-1]
					tick = tick - 2
				}
			}
		}
	} 

	if( dataMap['{'] == 0 && dataMap['('] == 0 && dataMap['['] == 0 && tick == 0){
		return true
	}

	return false
}