package program.code;

import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;

public class SubarraysDistinctElementSumOfSquares {

	public static int solution(List<Integer> nums) {
		
		var result = 0;
		
		var subs = new ArrayList<ArrayList<Integer>>();
		
		for(var i = 0; i < nums.size(); i++) { 
			for(var j = i; j < nums.size(); j++) {
				var list = new ArrayList<Integer>(); 
				for(var k = i; k <= j; k++ ) {  
					list.add(nums.get(k));
				} 
				subs.add(list);
			}
		}
		
	    for (var data : subs) {
			var set = new ArrayList<Integer>();
			int count = 0;
			for (var item : data) {
				if(!set.contains(item)) count++;
				set.add(item);
			}
			result += count * count;
		}
		
		return result;
		
	}
}
