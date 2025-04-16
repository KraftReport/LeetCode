package solutions;

public class LongestSubarrayOfOnesAfterDeletingOneElement {

	public static int solution(int[] nums) {
		var left = 0;
		var max = 0;
		var zero = 0;

		for (var right = 0; right < nums.length; right++) {
			if (nums[right] == 0) {
				zero++;
			}
			while (zero > 1) {
				if (nums[left] == 0) {
					zero--;
				}
				left++;
			}
			max = Math.max(max, right - left + 1);
		}
		return max - 1;
	}
}
