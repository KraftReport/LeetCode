class FindTheGoodTheNumberOfGoodPairs:
    def solutiion(self,nums1,nums2,k):
        count = 0
        for i,data1 in enumerate(nums1):
            for j,data2 in enumerate(nums2):
                if data1 % (data2 * k) == 0: count += 1
        return count 