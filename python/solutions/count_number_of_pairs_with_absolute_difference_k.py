class CountNumberOfPairsWithAbsoluteDifferenceK:

    def solution(self,nums,k): 
        result = 0 
        for i,num in enumerate(nums):
            j = i+1
            while j<len(nums) :
                if(abs(num-nums[j]) == k): 
                    result += 1
                j += 1

        return result