package solutions;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;
import java.util.stream.Collectors;

public class ReverseVowelsOfAString {

	public static String solution(String s) {

		var result = new StringBuilder();
		var extractedVowels = new ArrayList<String>();
		var dataList = s.chars().mapToObj(c -> String.valueOf((char)c)).toList();
		var vowelList = new ArrayList<>(List.of("a", "e", "i", "o", "u","A","E","I","O","U"));

		var modifiedList = dataList.stream().map(data -> {
			if (vowelList.contains(data)) {
				extractedVowels.add(data);
				return "empty";
			}
			return data;
		}).toList();

		Collections.reverse(extractedVowels);

		var extractedVowelsItrator = extractedVowels.iterator();

		var finalList = modifiedList.stream()
				.map(data -> data.equals("empty") && extractedVowelsItrator.hasNext() ? extractedVowelsItrator.next()
						: data)
				.toList();
		 
		finalList.forEach(result::append);
		
		return result.toString();

	}
}
