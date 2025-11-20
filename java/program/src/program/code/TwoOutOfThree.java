package program.code;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.HashSet;
import java.util.List;

public class TwoOutOfThree {

	public static List<Integer> solution(int[] nums1,int[] nums2,int[] nums3){
		var hashMap = new HashMap<Integer,Integer>();
		var result = new HashSet<Integer>();
		var list1 = new ArrayList<Integer>();
		var list2 = new ArrayList<Integer>(); 
		for (var num1 : nums1) {
			if(!hashMap.containsKey(num1)) {
				 hashMap.put(num1, 1);
				 list1.add(num1); 
			}
		}
		for (var num2 : nums2) {
			if(hashMap.containsKey(num2) && list1.contains(num2)) {
				result.add(num2);
				
			}else {
				list2.add(num2);
				hashMap.put(num2, 1);
			} 
		}
		for (var num3 : nums3) {
			if(hashMap.containsKey(num3) && (list2.contains(num3) || list1.contains(num3))) result.add(num3);
			else hashMap.put(num3, 1);
		} 
		return result.stream().toList();
	}
}
