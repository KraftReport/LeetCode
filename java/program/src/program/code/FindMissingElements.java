package program.code;

import java.util.ArrayList; 
import java.util.HashSet;
import java.util.List;

public class FindMissingElements {

	public static List<Integer> solution(int[] nums){ 
		var hashSet = new HashSet<Integer>();
		var smallest = nums[0];
		var largest = nums[0];
		var result = new ArrayList<Integer>();
		for (var num : nums) {
			if(num < smallest) smallest = num;
			if(num > largest) largest = num;
			hashSet.add(num);
		}
		while(smallest <= largest) {
			if(!hashSet.contains(smallest)) result.add(smallest);
			smallest++;
		}
		return result;
	}
}
