function twoSum(nums: number[], target: number): number[] {
    let finalarray = []
    for (let i = 0; i < nums.length; i++) {
        for (let j = i + 1; j < nums.length; j++) {
            let istargetvalue = nums[i] + nums[j];
            if (istargetvalue === target) {
                finalarray.push(i, j)
                return finalarray
            }
        }
    }
    return finalarray
};