package program.code;

import java.util.HashMap;

public class CheckAllCharactersHaveEqualNumbersOfOccurences {

	public static boolean solution(String s) {
		var count = 0;
		var hashMap = new HashMap<Character,Integer>();
		var characterArray = s.toCharArray();
		for (var character : characterArray) {
			if(!hashMap.containsKey(character)) {
				hashMap.put(character, 1);
			}else {
				var value = hashMap.get(character) + 1;
				hashMap.put(character, value);
			} 
		} 
		count = hashMap.get(characterArray[0]);
		for (var map : hashMap.values()) {
			if(map != count) return false;
		}
		return true;
	}
}
