package program.code;

import java.util.HashSet;

public class FindTheDistinctDifferenceArray {

	public static int[] solution(int[] nums) {
		var result = new int[nums.length]; 
		
		for(var i = 0; i < nums.length; i++) {	
			var prefixHashSet = new HashSet<Integer>();
			var suffixHashSet = new HashSet<Integer>();
			var prefix = 0;
			var suffix = 0;
			
			for(var j = i; j >= 0; j--) {
				if(!prefixHashSet.contains(nums[j])) {
					prefix++;
					prefixHashSet.add(nums[j]);
				}
			}
			
			for(var k = nums.length-1; k > i; k--) {
				if(!suffixHashSet.contains(nums[k])) {
					suffix++;
					suffixHashSet.add(nums[k]);
				}
			}
			result[i] = prefix -suffix;
		}
		
		return result;
	}
}
