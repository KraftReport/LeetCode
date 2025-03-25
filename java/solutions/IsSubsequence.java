package solutions;

public class IsSubsequence {

	public static boolean solution(String s, String t) {
		var sPointer = 0;
		var tPointer = 0;

		while (sPointer < s.length() && tPointer < t.length()) {
			if (s.charAt(sPointer) == t.charAt(tPointer)) {
				sPointer++;
			}
			tPointer++;
		}
		return s.length() == sPointer;
	}
}
