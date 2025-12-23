package program.code;

import java.util.HashMap; 

public class MakeTwoArraysEqualsByReversingSubArrays {

	public static boolean solution(int[] target,int[] arr) {
		var targetMap = new HashMap<Integer,Integer>();
		var arrMap = new HashMap<Integer,Integer>();
		for(var i = 0; i < target.length; i++) {
			if(targetMap.containsKey(target[i])) targetMap.put(target[i], targetMap.get(target[i])+1);
			else targetMap.put(target[i], 1);
			if(arrMap.containsKey(arr[i])) arrMap.put(arr[i], arrMap.get(arr[i])+1);
			else arrMap.put(arr[i], 1);
		}
		for (var data : arrMap.keySet()) {
			if(!targetMap.containsKey(data)) return false;
			if(targetMap.get(data).intValue() != arrMap.get(data).intValue()) {
				System.err.println(arrMap.get(data));
				System.out.println(targetMap.get(data));
				return false;
			}
		}
		return true;
	}
}
