package solutions;

public class IncreasingTripletSubsequence {

	public static boolean solution(int[] nums) {
		var first = Integer.MAX_VALUE;
		var second = Integer.MAX_VALUE;
		for(var num : nums) {
			if(num <= first) {
				first = num;
			}else if(num <= second) {
				second = num;
			}else {
				return true;
			}
		}
		return false;
	}
}
