package solutions;

import java.util.Arrays; 
import java.util.Collections;
import java.util.stream.Collectors;

public class ReverseWordsInAString {

	public static String solution(String s) {
		var dataList = Arrays.stream(s.trim().split("\\s+")).collect(Collectors.toList());
		Collections.reverse(dataList);
		return String.join(" ", dataList);
	}

}
