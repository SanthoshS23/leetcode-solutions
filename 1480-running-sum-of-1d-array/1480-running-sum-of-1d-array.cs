public class Solution {
    public int[] RunningSum(int[] nums) {
        int[] NewArr = new int[nums.Length];
        NewArr[0] = nums[0];
        for(int i=1;i<nums.Length;i++){
            NewArr[i] = NewArr[i-1] + nums[i];
        }
        return NewArr;
    }
}