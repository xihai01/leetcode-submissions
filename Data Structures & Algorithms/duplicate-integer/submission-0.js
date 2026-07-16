class Solution {
    /**
     * @param {number[]} nums
     * @return {boolean}
     */
    hasDuplicate(nums) {
        const history ={};

        for (let i in nums) {
            if (nums[i] === history[nums[i]]) {
                return true;
            }
            history[nums[i]] = nums[i]
        }
        return false;
    }
}
