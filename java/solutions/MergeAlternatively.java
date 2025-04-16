package solutions;

public class MergeAlternatively {

    public static String solution(String word1, String word2) {
    	var result = "";
        var firstWordSize = word1.length();
        var secondWordSize = word2.length();
        
        var commonLength = firstWordSize >= secondWordSize ? firstWordSize : secondWordSize;
        
        for(int i = 0 ; i < commonLength ; i++) {
        	
        	var boxOne = "";
        	var boxTwo = "";
        	
        	try {
        		boxOne = ""+word1.charAt(i);
        	}catch(Exception ex) {
        		boxOne = "";
        	}
        	
        	try {
        		boxTwo = ""+word2.charAt(i);
        	}catch(Exception ex) {
        		boxTwo = "";
        	} 
        	
        	result += boxOne+boxTwo;
        }
        
        return result;
        
    }

}
