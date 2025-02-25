package solutions;

import java.util.HashMap;

public class MaxNumbersOfKSumPairs {

	public static int solution(int[] nums, int k) {
		var result = 0;
		var box = new HashMap<Integer, Integer>();
		for(var num : nums) {
			var complement = k- num;
			if(box.getOrDefault(complement, 0) > 0) {
				result++;
				box.put(complement,box.getOrDefault(complement, 0)-1);
			}else {
				box.put(num, box.getOrDefault(num, 0)+1);
			}
		}
		return result;
	}
}
