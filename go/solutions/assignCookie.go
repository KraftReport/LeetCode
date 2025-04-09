package solutions

import ("sort")

func AssignCookieSolution(g []int,s []int) int{

	result := 0

	sort.Sort(sort.IntSlice(g))
	sort.Sort(sort.IntSlice(s))

	i,j := 0,0

	for i < len(g) &&  j < len(s){
		if g[i] <= s[j]{
			result++
			i++
		}
		j++
	}

	return result

}