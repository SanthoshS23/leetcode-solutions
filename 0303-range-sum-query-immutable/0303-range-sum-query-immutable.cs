public class NumArray {
    private int[] NewArr;
    public NumArray(int[] nums) {
        NewArr = new int[nums.Length];
        NewArr[0] = nums[0];
        for(int i=1;i<nums.Length;i++){
            NewArr[i] = NewArr[i-1] + nums[i];
        }                
    }
    
    public int SumRange(int left, int right) {
        if(left == 0){
            return NewArr[right];
        } return NewArr[right] - NewArr[left-1];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */