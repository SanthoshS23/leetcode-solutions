public class Solution {
    public int[] BuildArray(int[] nums) {
        int[] NewArr = new int[nums.Length];
        for(int i=0;i<nums.Length;i++) {
            int temp = nums[i];
            NewArr[i] = nums[temp];
        }
        return NewArr;
    }
}