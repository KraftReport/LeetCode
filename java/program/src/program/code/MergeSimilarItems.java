package program.code;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class MergeSimilarItems {

	public static List<List<Integer>> solution(int[][] items1,int[][] items2){
		var hashMap = new HashMap<Integer,Integer>();
		var result = new ArrayList<List<Integer>>();
		for (var item1 : items1) {
			if(hashMap.containsKey(item1[0])) hashMap.put(item1[0], hashMap.get(item1[0]) + item1[1]);
			else hashMap.put(item1[0], item1[1]);
		}
		for (var item2 : items2) {
			if(hashMap.containsKey(item2[0])) hashMap.put(item2[0], hashMap.get(item2[0]) + item2[1]);
			else hashMap.put(item2[0], item2[1]);
		}
		for (var key : hashMap.keySet().stream().sorted().toList()) {
			var list = new ArrayList<Integer>();
			list.add(key);
			list.add(hashMap.get(key));
			result.add(list);
		}
		return result;
	}
}
