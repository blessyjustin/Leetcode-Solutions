class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        no_hash={}
        for i in range(len(nums)):
            if nums[i] in no_hash:
                return True
            no_hash[nums[i]]=i
        return False