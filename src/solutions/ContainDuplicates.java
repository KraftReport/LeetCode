package solutions;

import java.util.HashMap;

public class ContainDuplicates {

	public static boolean solution(int[] nums) {
		var map = new HashMap<Integer, Integer>();
		var result = false;
		for (var num : nums) {
			if (map.containsKey(num)) {
				result = true;
			} else {
				map.put(num, 1);
			}
		}
		return result;
	}
}
