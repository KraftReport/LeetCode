package solutions

func ThreeConcetutiveOdds(arr []int)bool{
	count := 0
 
	for _ , value := range arr{
		if count == 3 {
			break
		}
		if value%2 == 0 {
			count = 0
		}else{
			count++
		} 
	} 

	if count < 3 {
		return false
	}
	return true
}