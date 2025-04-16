package solutions;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class KidsWithTheGreatestNumberOfCandies {

	public static List<Boolean> solution(int[] candies, int extraCandies) {

		var result = new ArrayList<Boolean>();
		var dataList = Arrays.stream(candies).boxed().collect(Collectors.toList());

		dataList.forEach(children -> {
 
			var cup = children + extraCandies;
			var others = dataList.stream().filter(data -> !data.equals(children)).toList();
			var box = others.stream().allMatch(other-> cup >= other);
			result.add(box);
			
		});
		return result;
	}

}
