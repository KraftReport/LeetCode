package program.code;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class FindKSumOfAllKLongSubArrays {

	public static int[] solution(int[] nums,int k,int x) {
		var result = new ArrayList<Integer>();
		for(int i = 0; i + k <= nums.length; i++) {
			var cup = 0;
			var hashMap = new HashMap<Integer,Integer>();
			for(int j = i; j < k+i; j++) {
				if(hashMap.containsKey(nums[j])) hashMap.put(nums[j], hashMap.get(nums[j]) + 1);
				else hashMap.put(nums[j], 1);
			}
			List<Map.Entry<Integer, Integer>> sortedList =
			        hashMap.entrySet()
			           .stream()
			           .sorted(
			               Map.Entry.<Integer, Integer>comparingByValue(Comparator.reverseOrder())
			                        .thenComparing(Map.Entry.comparingByKey(Comparator.reverseOrder()))
			           )
			           .limit(x)
			           .toList();
			for (var map : sortedList) {
				cup += map.getKey() * map.getValue();
			}
			result.add(cup);
		}
		return  result.stream()
                .mapToInt(Integer::intValue)
                .toArray();
	}
}
