function maxSubArray(nums: number[]): number {
    let currentSum = nums[0];
    let maxSum = nums[0];
    for(let first = 1; first<nums.length; first++) {
       currentSum = Math.max(currentSum+nums[first], nums[first]);
       maxSum = Math.max(currentSum,maxSum)
    }
    return maxSum;
};