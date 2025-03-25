package solutions;

import java.util.ArrayList;

public class StringCompression {

	public static int solution(char[] chars) {

		var read =0; 
		var wirte = 0;
		
		while(read<chars.length) {
			var currentChar = chars[read];
			var count = 0;
			
			while(read<chars.length && chars[read] == currentChar) {
				read++;
				count++;
			}
			 
			chars[wirte++] = currentChar;
			
			if(count>1) {
				for(var c : String.valueOf(count).toCharArray()) {
					chars[wirte++] = c;
				}
			}
		}
		return wirte;
		
	}

}
