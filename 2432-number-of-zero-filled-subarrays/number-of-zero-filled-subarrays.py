class Solution:
    def zeroFilledSubarray(self, nums: List[int]) -> int:
        count=0
        zerocount=0
        for n in nums:
            if n==0:
                zerocount+=1
            else:
                zerocount=0
            count+=zerocount
        return count