package program.code;

import java.sql.Array;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.HashSet;

public class UncommonWordsFromTwoSentences {

	public static String[] solution(String s1,String s2) {
		var hashMapOne = new HashMap<String,Integer>();
		var hashMapTwo = new HashMap<String,Integer>();	
		var result = new HashSet<String>();
		
		
		for (var data : Arrays.asList(s1.split("\\s+"))) {
			if(hashMapOne.containsKey(data)) hashMapOne.put(data, hashMapOne.get(data)+1);
			else hashMapOne.put(data, 1);
		}
		for (var data : Arrays.asList(s2.split("\\s+"))) {
			if(hashMapTwo.containsKey(data)) hashMapTwo.put(data, hashMapTwo.get(data)+1);
			else hashMapTwo.put(data, 1);
		}
		for (var data : Arrays.asList(s1.split("\\s+"))) {
			if(!hashMapTwo.containsKey(data) && hashMapOne.get(data) == 1) result.add(data);
		}
		for (var data : Arrays.asList(s2.split("\\s+"))) {
			if(!hashMapOne.containsKey(data) && hashMapTwo.get(data) == 1) result.add(data);
		}
		return result.toArray(new String[0]);
	}
	
}
