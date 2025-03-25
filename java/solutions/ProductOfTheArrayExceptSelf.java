package solutions;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.stream.Collector;
import java.util.stream.Collectors;

public class ProductOfTheArrayExceptSelf {

	public static int[] solution(int[] nums) {

		var result = new int[nums.length];

		result[0] = 1;
		for (int i = 1; i < nums.length; i++) {
			result[i] = result[i - 1] * nums[i - 1];
		}

		var suffix = 1;
		for (int j = nums.length - 1; j >= 0; j--) {
			result[j] *= suffix;
			suffix *= nums[j];
		}

		return result;

	}
}
