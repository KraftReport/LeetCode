package program.code;

import java.util.AbstractMap.SimpleEntry;
import java.util.HashMap;
import java.util.List;

public class DestinationCity {

	public static String solution(List<List<String>> paths) {
		var map = new HashMap<String,SimpleEntry<Integer,Integer>>();
		 
		for (var path : paths) {
			map.put(path.get(0), new SimpleEntry<>(map.get(path.get(0))== null ? 0 +1 : map.get(path.get(0)).getKey() +1,0)); 
			map.put(path.get(1), new SimpleEntry<>(map.get(path.get(1))== null ? 0 +1 : map.get(path.get(1)).getKey() +1,1));
		}
		 
		for (var data : map.keySet()) { 
			if(map.get(data).getKey() == 1 && map.get(data).getValue() == 1) return data;
		}
		return new String();
	}
}
