package solutions;

import java.util.HashSet;

public class GreatestCommonDivisorOfStrings {

	public static String solution(String stringOne, String stringTwo) {

		var b = stringTwo.length();
		var a = stringOne.length();

		if (!(stringOne + stringTwo).equals(stringTwo + stringOne)) {
			return "";
		}

		while (b != 0) {
			int temp = b;
			b = a % b;
			a = temp;
		}

		return stringOne.substring(0, a);

	}
}
