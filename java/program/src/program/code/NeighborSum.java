package program.code;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Hashtable;
 

public class NeighborSum {  
	
	HashMap<Integer, int[]> hashMap = new HashMap<Integer,int[]>();
	int[][] map;
	
    public NeighborSum(int[][] grid) { 
    	map = grid;
        for(var i = 0; i<grid.length; i++) {
        	for(var j = 0; j <grid[i].length; j++) {
        		hashMap.put(grid[i][j],new int[] {i,j});
        	}
        }
    }
    
    public int adjacentSum(int value) { 
        var coordinates = hashMap.get(value); 
        return getValue(coordinates[0]-1, coordinates[1]) +
        	   getValue(coordinates[0]+1, coordinates[1]) +
        	   getValue(coordinates[0], coordinates[1]-1) +
        	   getValue(coordinates[0], coordinates[1]+1);
    }
    
    public int diagonalSum(int value) {
        var coordinates = hashMap.get(value);
        return getValue(coordinates[0]-1, coordinates[1]-1) +
         	   getValue(coordinates[0]-1, coordinates[1]+1) +
         	   getValue(coordinates[0]+1, coordinates[1]-1) +
         	   getValue(coordinates[0]+1, coordinates[1]+1); 
    }
    
    private int getValue(int r,int c) {
    	if(r < 0 || r > map.length || c < 0 || c > map.length) return 0;
    	return map[r][c];
    }
}
