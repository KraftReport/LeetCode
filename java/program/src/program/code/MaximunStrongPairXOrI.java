package program.code;

public class MaximunStrongPairXOrI {

	public static int solution(int[] nums) {
		var result = 0;
		for(var i = 0; i < nums.length;i++) {
			for(var j = 0 ; j < nums.length; j++) {
				if(j!= i) {
					if(Math.abs(nums[i]-nums[j]) <= Math.min(nums[i], nums[j])) {
						if((nums[i] ^ nums[j]) > result) {
							result = nums[i] ^ nums[j];
						}
					}
				}
			}
		}
		return result;
	}
}
