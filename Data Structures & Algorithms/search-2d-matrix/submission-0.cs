public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        // find the row that contains the target
        // if the row is found, do a binary search to find the target
        for (int i = 0; i < matrix.Length; i++) {
            for (int j = 0; j < matrix[i].Length; j++) {
                if (target >= matrix[i][j] && target <= matrix[i][matrix[i].Length - 1]) {
                    // binary search
                    return BinarySearch(matrix[i], target);
                }
                // skip
                break;
            }
        }
        return false;
    }

    public bool BinarySearch(int[] nums, int target) {
        int l = 0;
        int r = nums.Length - 1;
        //iteration - cut in half each time
        int curr = (l+r)/2;
        while(l<=r) {
            //check the curr value with target
            if (nums[curr] == target) return true;
            // update l and r accordingly
            if (nums[curr] < target) {
                l = curr + 1;
            }
            if (nums[curr] > target) {
                r = curr - 1;
            }
            curr = (l+r)/2;
        }
        return false;
    }
}
