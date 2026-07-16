class Solution {
    /**
     * @param {number[]} nums
     * @param {number} target
     * @return {number[]}
     */
    twoSum(nums, target) {
        // create a hash to store the difference and its index
        // { [dff]: [idx] }
        // iterate through nums, see if current value of nums is in hash
        // if exists, return the two idx: stored in hash[diff] and curr idx of loop
        // if not exists, add the diff and idx to hash
        const hash = {};

        for (const i in nums) {
            const currValue = nums[i];
            const diff = target - currValue;
            if (hash[diff] === undefined) {
                hash[currValue] = i;
            } else {
                return [parseInt(hash[diff]), parseInt(i)];
            }
        }
    }
}
