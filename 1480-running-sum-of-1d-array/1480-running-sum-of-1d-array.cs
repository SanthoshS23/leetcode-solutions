public class Solution {
    public int[] RunningSum(int[] nums) {
        int[] NewArr = new int[nums.Length];
        int count = nums[0];
        NewArr[0] = nums[0];
        for(int i=1;i<nums.Length;i++){
            NewArr[i] = count + nums[i];
            count = count + nums[i];
        }
        return NewArr;
    }
}