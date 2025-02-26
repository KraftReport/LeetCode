package solutions;

public class MaximunAverageSubArray {

	public static double solution(int[] nums, int k) {
		var sum = 0.0;
		for(int i = 0 ;i <k ; i++) {
			sum += nums[i];
		}
		var max = sum;
		for(int i = k ; i < nums.length ; i++) {
			sum = sum - nums[i-k] + nums[i];
			max = Math.max(max, sum);
		}
		return max/k;
	}
}
