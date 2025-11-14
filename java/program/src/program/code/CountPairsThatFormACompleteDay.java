package program.code;
 

public class CountPairsThatFormACompleteDay {

	public static int solution(int[] hours) {
		var result = 0;
		for(var i = 0; i < hours.length; i++) {
			for(var j = i+1; j < hours.length; j++) {
				if(i!=j) { 
					if((hours[i]+hours[j]) / 24 >= 1 && (hours[i]+hours[j]) % 24 == 0) result++;
				}
			}
		}
		return result;
	}
}
