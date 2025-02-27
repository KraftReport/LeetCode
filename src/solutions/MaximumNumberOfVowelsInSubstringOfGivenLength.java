package solutions;

import java.util.regex.Pattern;

public class MaximumNumberOfVowelsInSubstringOfGivenLength {

	public static int solution(String s, int k) {
		var vowels = "aeiou";
		var count = 0;
		var max = 0;
		for (int i = 0; i < k; i++) {
			if (vowels.indexOf(s.charAt(i)) != -1) {
				count++;
			}
		}
		max = count;
		for (int i = k; i < s.length(); i++) {
			if (vowels.indexOf(s.charAt(i - k)) != -1)
				count--;
			if (vowels.indexOf(s.charAt(i)) != -1)
				count++;
			max = Math.max(max, count);
		}
		return max;
	}
}
