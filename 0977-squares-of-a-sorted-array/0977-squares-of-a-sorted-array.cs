public class Solution {
    public int[] SortedSquares(int[] nums) {
        int n = nums.Length;
        int[] NewArr =new int[n];
        int left = 0;
        int right = n-1;
        int index = n-1;
        while(left<=right){
            if(Math.Abs(nums[left]) < Math.Abs(nums[right])){
                NewArr[index] = nums[right] * nums[right];
                right--;
            } else {
                NewArr[index] = nums[left] * nums[left];
                left++;
            }
            index--;
        }
        return NewArr;
    }
}