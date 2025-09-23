class TwoSneakyNumbersOfDigitVille:

    def solution(self,nums):

        map = {}
        result = []

        for i,num in enumerate(nums):
            if num in map:
                result.append(num)
                if len(result) > 1 :
                    return result 
            else:
                map[num] = i

        return []
