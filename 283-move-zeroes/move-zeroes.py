class Solution:
    def moveZeroes(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        insert_pos = 0

        for i in range(len(nums)):
            if nums[i] != 0:
                # Only swap when the element isn't already in position
                if i != insert_pos:
                    nums[insert_pos] = nums[i]
                    nums[i] = 0
                insert_pos += 1