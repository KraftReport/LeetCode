package solutions  
// import "fmt"

func TeemoAttackSolution(timeSeries []int ,duration int) int { 
	lastAttack := 0
	result := 0
	for j := 0; j < len(timeSeries); j++ { 
		currentAttack := timeSeries[j]
		if(currentAttack > lastAttack) { 
			result += duration   
		}else if(currentAttack <= lastAttack) {  
			result += (currentAttack + duration) - lastAttack
		} 
		lastAttack = currentAttack + duration
	}
	return  result
}