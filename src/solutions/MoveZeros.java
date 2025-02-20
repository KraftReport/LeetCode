package solutions;

public class MoveZeros {

	public static int[] solution(int[] nums) {
		var leftPointer = 0;
		for(var rightPointer = 0; rightPointer<nums.length; rightPointer++ ) {
			if(nums[rightPointer] != 0) {
				var temp = nums[leftPointer];
				nums[leftPointer] = nums[rightPointer];
				nums[rightPointer] = temp;
				leftPointer++;
			}
		}
		return nums;
	}
}
