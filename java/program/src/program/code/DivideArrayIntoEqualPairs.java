package program.code;
 
import java.util.HashSet;

public class DivideArrayIntoEqualPairs {

	public static boolean solution(int[] nums) {
		var set = new HashSet<Integer>();
		for (var num : nums) {
			if(set.contains(num)) set.remove(num);
			else set.add(num); 
		} 
		return set.size() == 0;
	}
}
