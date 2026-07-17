public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0;
        int r = nums.Length - 1;
        //iteration - cut in half each time
        int curr = (l+r)/2;
        while(l<=r) {
            //check the curr value with target
            if (nums[curr] == target) return curr;
            // update l and r accordingly
            if (nums[curr] < target) {
                l = curr + 1;
            }
            if (nums[curr] > target) {
                r = curr - 1;
            }
            curr = (l+r)/2;
        }
        return -1;
    }
}
