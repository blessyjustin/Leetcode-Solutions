class Solution:
    def containsNearbyDuplicate(self, nums: List[int], k: int) -> bool:
        mapHash={}
        for i in range(len(nums)):
            if nums[i] in mapHash:
                if abs(mapHash[nums[i]]-i)<=k:
                    return True
            mapHash[nums[i]]=i
        return False
