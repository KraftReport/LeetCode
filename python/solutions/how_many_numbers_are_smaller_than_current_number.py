class HowManyNumbersAreSmallerThanCurrentNumbers:
    def solution(self,nums):
        map = {}
        sorted_nums = sorted(nums)

        for i,num in enumerate(sorted_nums):
            if num not in map:
                map[num] = i

        return [map[num] for num in nums]