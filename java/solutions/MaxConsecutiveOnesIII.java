package solutions;

public class MaxConsecutiveOnesIII {

	public static int solution(int[] nums, int k) {
		int left = 0, maxLen = 0, zeroCount = 0;

		for (int right = 0; right < nums.length; right++) {
			if (nums[right] == 0) {
				zeroCount++;
			}

			while (zeroCount > k) {
				if (nums[left] == 0) {
					zeroCount--;
				}
				left++;
			}

			maxLen = Math.max(maxLen, right - left + 1);
		}
		return maxLen;
	}
}
