class CountNumberOfConsistentStrings:

    def solution(self,allowed,words):
        map = set(allowed)
        result = len(words)
        for word in words:
            isConsistent = False 
            for character in word:
                if character in map:
                    isConsistent = True 
                else: 
                    isConsistent = False
                    break
            if not isConsistent:
                result = result-1
        return result


        