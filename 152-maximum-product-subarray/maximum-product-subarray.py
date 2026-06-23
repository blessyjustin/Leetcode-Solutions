class Solution:
    def maxProduct(self, nums: List[int]) -> int:
        minimum=nums[0]
        maximum=nums[0]
        ans=maximum
        for i in range(1,len(nums)):
            temp=min(nums[i],nums[i]*minimum,nums[i]*maximum)
            maximum=max(nums[i],nums[i]*minimum,nums[i]*maximum)
            minimum=temp
            ans=max(ans,maximum)
        return ans
    