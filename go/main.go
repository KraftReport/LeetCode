package main

import (
	"fmt"
	"leetcode/solutions"
)

func main() {
	// fmt.Println(solutions.MajorityElementSolution([]int{3, 2, 3})) // 3
	// fmt.Println(solutions.MissingNumberSolution([]int{1,0,3}))
	// fmt.Println(solutions.AssignCookieSolution([]int{1,2,3},[]int{1,1}))
	// fmt.Println(solutions.IslandPerimeterSolution([][]int{{0,1,0,0},{1,1,1,0},{0,1,0,0},{1,1,0,0}}))
	fmt.Println(solutions.MaxConsecutiveOnesSolution([]int{1,1,0,1,1,1}))
}
