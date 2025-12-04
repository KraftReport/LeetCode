package program.code;

import java.util.HashMap;

public class SumOfElementsWithFrequencyDivisibleByK {

	public static int solution(int[] nums,int k) {
		var result = 0;
		var hashMap = new HashMap<Integer,Integer>();
		for (var num : nums) {
			if(hashMap.containsKey(num)) {
				hashMap.put(num, hashMap.get(num)+ 1);
			}else {
				hashMap.put(num, 1);
			}
		}
		for (var map : hashMap.keySet()) {
			if(hashMap.get(map) % k == 0) {
				result += map * hashMap.get(map);
			}
		}
		return result;
	}
}
