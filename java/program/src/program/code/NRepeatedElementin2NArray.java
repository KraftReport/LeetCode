package program.code;

import java.util.HashMap;

public class NRepeatedElementin2NArray {

	public static int solution(int[] nums) {
		var hashMap = new HashMap<Integer,Integer>();
		for (var num : nums) {
			if(hashMap.containsKey(num)) hashMap.put(num, hashMap.get(num) + 1);
			else hashMap.put(num, 1);
			if(hashMap.get(num) == nums.length / 2) return num;
		} 
		return 0;
	}
}
