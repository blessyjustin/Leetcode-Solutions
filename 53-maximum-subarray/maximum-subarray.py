class Solution:
    def maxSubArray(self, nums: List[int]) -> int:
        currentSum=0
        maxSum=nums[0]
        for i in range(len(nums)):
            if currentSum<0:
                currentSum=0
            currentSum+=nums[i]
            if currentSum>maxSum:
                maxSum=currentSum
        return maxSum