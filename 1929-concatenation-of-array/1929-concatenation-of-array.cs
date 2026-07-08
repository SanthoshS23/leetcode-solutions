public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int length = nums.Length;
        int[] Result = new int[2*length];
        for(int i=0;i<length;i++ ) {
            Result[i] = nums[i];
            Result[i+length] = nums[i];
        }
        return Result;
    } 
}