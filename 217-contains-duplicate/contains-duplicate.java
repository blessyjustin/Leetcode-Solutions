class Solution {
    public boolean containsDuplicate(int[] nums) {
        HashSet<Integer> newnums= new HashSet<>();
        for(int num:nums)
        {
            if(newnums.contains(num)){
                return true;
        }
        newnums.add(num);
        }
        return false;
    }
}