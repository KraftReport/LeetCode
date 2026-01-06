package program.code;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collection;
import java.util.Collections;
import java.util.Comparator;
import java.util.HashSet;
import java.util.List;
import java.util.TreeMap;
import java.util.TreeSet;
import java.util.stream.Collectors; 

public class MaximizeAtMostSumOfKDistinctElements {

	public static int[] solution(int[] nums,int k) {
		Integer[] list = Arrays
				.stream(nums)
				.boxed()
				.collect(Collectors
						.toCollection(()->new TreeSet<>(Comparator
								.reverseOrder())))
				.toArray(new Integer[0]);
		int[] arr = Arrays.stream(list)
				.mapToInt(Integer::intValue)
				.toArray(); 
		
		var result = new int[Math.min(k, arr.length)];
		for(var i = 0;  i< result.length ; i++) {
			result[i] = arr[i];
		}
		return result;
	}
}
