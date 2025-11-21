package program.code;

import java.util.ArrayList;
import java.util.Collections;
import java.util.HashMap;
import java.util.HashSet;
import java.util.stream.Collectors;

public class IncreasingDecreasingString {

	public static String solution(String s) {
		var result = "";
		var hashMap = new HashMap<Character,Integer>();
		for (var c : s.toCharArray()) {
			if(hashMap.containsKey(c)) {
				hashMap.put(c, hashMap.get(c)+1);
			}else {
				hashMap.put(c, 1);
			}
		}
		var count = hashMap.size();
		var hashSet = new HashSet<>();
		while (count > 0) {
			var word = new ArrayList<Character>();
			for (var map : hashMap.keySet()) {
				if(hashMap.get(map) > 0) {
					word.add(map);
					hashMap.put(map, hashMap.get(map)-1);
				}
				if(hashMap.get(map) == 0 && !hashSet.contains(map)) {
					count--;  
					hashSet.add(map);
				}
			}
			Collections.sort(word);
			result += word.stream()
                    .map(String::valueOf)
                    .collect(Collectors.joining());
			
			word = new ArrayList<Character>();
			for (var map : hashMap.keySet()) {
				if(hashMap.get(map) > 0) {
					word.add(map);
					hashMap.put(map, hashMap.get(map)-1);
				}
				if(hashMap.get(map) == 0 && !hashSet.contains(map)) {
					count--;  
					hashSet.add(map);
				}
			}
			Collections.sort(word,Collections.reverseOrder());
			result += word.stream()
                    .map(String::valueOf)
                    .collect(Collectors.joining());
		}
		return result;
	}
}
