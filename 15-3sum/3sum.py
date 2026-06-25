class Solution:
    def threeSum(self, nums: list[int]) -> list[list[int]]:
        result=set()
        nums.sort()
        for i in range (0,len(nums)):
            if  nums[i]<=0:
                target=-1*(nums[i])
                hashset={}
                for n in range(i+1,len(nums)):
                    diff=target-nums[n]
                    if diff in hashset:
                        result.add(tuple([nums[i],diff,nums[n]]))
                    hashset[nums[n]]=n
        return [list(t) for t in result]

