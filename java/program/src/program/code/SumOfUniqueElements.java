package program.code;

import java.util.HashMap;

public class SumOfUniqueElements {

	public static int solution(int[] nums) {
		var map = new HashMap<Integer,Boolean>();
		var result = 0;
		for (var number : nums) {
			if(map.containsKey(number)) {
				if(map.get(number)) {
					result -= number;
					map.put(number, false);
				}
			}else {
				result += number;
				map.putIfAbsent(number, true);
			}
		}
		return result;
	}
}
