package program.code;
 
import java.util.HashSet;

public class MaximunNumberOfPairsInTheArray {

	public static int[] solution(int[] nums) {
		var pairCount = 0;
		var hashSet = new HashSet<Integer>();
		for (var num : nums) {
			if (hashSet.contains(num)) {
				pairCount++;
				hashSet.remove(num);
			} else {
				hashSet.add(num);
			}
		}
		return new int[] { pairCount, hashSet.size() };
	}
}
