package program.code;
 
import java.util.HashMap;
import java.util.HashSet;

public class UniqueNumberOfOccurences {

	public static boolean solution(int[] arr) {
		var hashMap = new HashMap<Integer,Integer>();
		for (var data : arr) {
			if(hashMap.containsKey(data)) hashMap.put(data, hashMap.get(data) + 1);
			else hashMap.put(data, 1);
		}
		var hashSet = new HashSet<>(hashMap.values());
		return hashSet.size() == hashMap.size();
	}
}
