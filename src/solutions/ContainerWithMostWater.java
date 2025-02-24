package solutions;

public class ContainerWithMostWater {

	public static int solution(int[] height) {
		var left = 0;
		var right = height.length - 1;
		var maxWater = 0;

		while (left < right) {
			var area = Math.min(height[left], height[right]) * (right - left);
			maxWater = Math.max(area, maxWater);
			if (height[left] < height[right]) {
				left++;
			} else {
				right--;
			}
		}

		return maxWater;
	}
}
