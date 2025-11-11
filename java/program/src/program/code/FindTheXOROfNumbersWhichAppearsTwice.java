package program.code;

import java.util.ArrayList;
import java.util.HashMap;

public class FindTheXOROfNumbersWhichAppearsTwice {

	public static int solution(int[] nums) {
		
		var hashMap = new HashMap<Integer,Integer>();
		
		for (var num : nums) { 
			if(hashMap.containsKey(num)) hashMap.put(num, hashMap.get(num)+1);
			
			else hashMap.put(num, 1); 
		} 
		
		var filtered = new ArrayList<Integer>();
		
		for (var item : hashMap.keySet()) {
			if(hashMap.get(item) == 2) filtered.add(item);
		} 
		
		if(filtered.size()==0) return 0;
		
		if(filtered.size()==1) return filtered.get(0);
		
		var result = filtered.get(0);
		
		for(var i = 1; i < filtered.size(); i++) { 
			result = result ^ filtered.get(i); 
		}
		 
		return result;
	}
}
