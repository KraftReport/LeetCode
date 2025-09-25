class PermutationDifferenceBetweenTwoStrings:
    
    def solution(self,s,t):
        
        result = 0
        map = {}
        
        for i,char in enumerate(s):
            if char not in map:
                map[char] = i
            
        for i,char in enumerate(t):
            if char in map:
                result += abs(map[char] - i)

        return result