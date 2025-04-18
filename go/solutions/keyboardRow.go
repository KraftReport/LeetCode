package solutions

func KeyboardRowSolution(words []string)[]string{
	
	firstRowMap := map[string]bool{
		"q": true, "w": true, "e": true, "r": true, "t": true,
		"y": true, "u": true, "i": true, "o": true, "p": true,
		"Q": true, "W": true, "E": true, "R": true, "T": true,
		"Y": true, "U": true, "I": true, "O": true, "P": true,
	}

	secondRowMap := map[string]bool{
		"a": true, "s": true, "d": true, "f": true, "g": true,
		"h": true, "j": true, "k": true, "l": true,
		"A": true, "S": true, "D": true, "F": true, "G": true,
		"H": true, "J": true, "K": true, "L": true,
	}

	thirdRowMap := map[string]bool{
		"z": true, "x": true, "c": true, "v": true, "b": true,
		"n": true, "m": true,
		"Z": true, "X": true, "C": true, "V": true, "B": true,
		"N": true, "M": true,
	}

	result := []string{}

	for i := 0 ; i < len(words) ; i++{

		chars := []rune(words[i])

		if firstRowMap[string(chars[0])]{
			firstCount := 0

			firstStillValid := true 

			for f := 0 ; f < len(chars) && firstStillValid ; f++{
				if firstRowMap[string(chars[f])] { 
					firstCount++ 
				}else {
					firstStillValid = false
				} 
			}

			if firstCount==len(chars) {
				result = append(result,words[i])
			}

		}

		if secondRowMap[string(chars[0])] {
			secondCount := 0

			secondStillValid := true 

			for f := 0 ; f < len(chars) && secondStillValid ; f++{
				if secondRowMap[string(chars[f])] { 
					secondCount++ 
				}else {
					secondStillValid = false
				} 
			}

			if secondCount==len(chars) {
				result = append(result,words[i])
			}

		}

		if thirdRowMap[string(chars[0])] {
			thirdCount := 0

			thirdStillValid := true 

			for f := 0 ; f < len(chars) && thirdStillValid ; f++{
				if thirdRowMap[string(chars[f])] { 
					thirdCount++ 
				}else {
					thirdStillValid = false
				} 
			}

			if thirdCount==len(chars) {
				result = append(result,words[i])
			}
		}
	}

	return result
}