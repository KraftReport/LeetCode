package solutions;


public class SortArrayByIncreasingFrequency{
    public static int[] solution(int[] nums){
        Map<Integer, Long> frequencyMap = IntStream.of(nums)
            .boxed()
            .collect(Collectors.groupingBy(n -> n, Collectors.counting()));
 
        return Arrays.stream(nums)
            .boxed()
            .sorted((a, b) -> {
                int cmp = frequencyMap.get(a).compareTo(frequencyMap.get(b));  
                if (cmp != 0) return cmp;                                      
                return b.compareTo(a);                                         
            })
            .mapToInt(Integer::intValue)
            .toArray();
    }
}