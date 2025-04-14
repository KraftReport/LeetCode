package solutions

func IslandPerimeterSolution(grid [][]int)int{
	rows := len(grid)
	cols := len(grid[0])
	perimeter := 0

	for i := 0 ; i < rows ; i++ {
		for j := 0 ; j < cols ; j++ {
			if grid[i][j] == 1 {
				perimeter += 4
				if i > 0 && grid[i-1][j] == 1 {
					perimeter -= 1
				}
				if i < rows-1 && grid[i+1][j] == 1 {
					perimeter -= 1
				}
				if j > 0 && grid[i][j-1] == 1 {
					perimeter -= 1
				}
				if j < cols-1 && grid[i][j+1] == 1 {
					perimeter -= 1
				} 
			}
		}
	}

	return perimeter
}