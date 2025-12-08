package program.code;

import java.util.HashSet;

public class SubstringsOfSizeThreeWithDistinctCharacters {

	public static int solution(String s) {
		var result = 0;
		for(var i = 0; i<s.toCharArray().length-2; i++) {
			var hashSet = new HashSet<Character>(); 
			hashSet.add(s.toCharArray()[i]);
			hashSet.add(s.toCharArray()[i+1]);
			hashSet.add(s.toCharArray()[i+2]);  
			System.err.println(i);
			System.out.println(hashSet.toString());
			if(hashSet.size() == 3) result++;
		}
		return result;
	}
}
