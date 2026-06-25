class Solution:
    def threeSum(self, nums: list[int]) -> list[list[int]]:
        result=set()
        nums.sort()
        for i in range (0,len(nums)):
            if  nums[i]>0:
                break
            target=-1*(nums[i])
            left=i+1
            right=len(nums)-1
            while(left<right):
                if (nums[left]+nums[right])==target:
                    result.add((nums[i],nums[left],nums[right]))
                    left+=1
                    right-=1
                if (nums[left]+nums[right])>target:
                    right-=1
                elif (nums[left]+nums[right])<target:
                    left+=1
        return [list(t) for t in result]

