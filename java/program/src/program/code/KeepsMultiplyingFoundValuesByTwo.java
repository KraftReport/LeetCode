package program.code;

import java.util.Arrays;

public class KeepsMultiplyingFoundValuesByTwo {

	public static int solution(int[] nums,int original) {
		var list = Arrays.stream(nums).boxed().toList();
		while(list.contains(original)) {
			original = original * 2;
		}
		return original;
	}
}
