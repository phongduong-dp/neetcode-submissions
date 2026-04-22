class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        s = []
        for num in nums:
            if num not in s:
                s.append(num)
            else:
                return True
        
        return False
