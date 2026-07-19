public class Solution {
    public int LengthOfLongestSubstring(string s) {
        //keep track of maxCount and currCount
        int maxCount = 0;
        int currCount = 0;
        // edge cases: when s is 0 or 1 in length
        //if (s.Length == 0) return 0;
        //if (s.Length == 1) return 1;

        //map to track of duplicates in window
        Dictionary<char, int> map = new Dictionary<char, int>();

        // sliding window with two pointers
        int l = 0;
        int r = 0;
        while (r < s.Length) {
            // duplicate?
            if (map.ContainsKey(s[r])) {
                maxCount = Math.Max(maxCount, currCount);
                currCount = 0;
                // update left window to start from one position after the repeated char
                l = map[s[r]] + 1;
                r = map[s[r]] + 1;
                map.Clear();
            }
            map[s[r]] = r;
            currCount++;
            maxCount = Math.Max(maxCount, currCount);
            r++;
        }
        return maxCount;
    }
}
