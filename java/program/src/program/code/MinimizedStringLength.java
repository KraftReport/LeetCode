package program.code;
 
import java.util.stream.Collectors;

public class MinimizedStringLength {

	public static int solution(String s) {
		return s
				.chars()
				.mapToObj(c->(char)c)
				.collect(Collectors.toSet())
				.size(); 
	}
}
