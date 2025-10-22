package program.code;

import java.util.Arrays;
import java.util.concurrent.atomic.AtomicInteger;
import java.util.stream.Collectors;

public class MaxFrequencyElements {

	public static int solution(int[] nums) {
		
		var currentLargest = new AtomicInteger(0);
		var result = new AtomicInteger(0);
		
		var map = Arrays.stream(nums)
				.boxed()
				.collect(Collectors.groupingBy(
						num->num,
						Collectors.counting()));
		
		System.out.println(map.toString());
		
		map.forEach((k,v)->{
			if(v>currentLargest.get()) {
				currentLargest.set(v.intValue());
				result.set(v.intValue());
				return;
			}
			if(v == currentLargest.get()) result.addAndGet(v.intValue());
		});
		
		return result.get();
		
	}
}
