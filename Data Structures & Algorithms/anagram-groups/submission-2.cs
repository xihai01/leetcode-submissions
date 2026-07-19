public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = new List<List<string>>();
        //keep track of the index of found anagrams
        var ana = new HashSet<int>();
        //compare each word to each other word
        for (int i = 0; i < strs.Length; i++) {
            // temp list to store found anagrams
            var temp = new List<string>();
            for (int j = 0; j < strs.Length; j++) {
                //ignore if this word was already included in an anagram group
                bool isAna = IsAnagram(strs[i], strs[j]);
                if (!ana.Contains(j) && isAna) {
                    temp.Add(strs[j]);
                    ana.Add(j);
                }
            }
            if (temp.Count != 0) res.Add(temp);
        }
        return res;
    }

    //checks if two strings are anagrams
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        var uniqueS = new Dictionary<char, int>();
        var uniqueT = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++) {
            // dups are ignored
            if (!uniqueS.ContainsKey(s[i]))
            {
                uniqueS.Add(s[i], 1);
            } else {
                uniqueS[s[i]]++;
            }

            if (!uniqueT.ContainsKey(t[i]))
            {
                uniqueT.Add(t[i], 1);
            } else {
                uniqueT[t[i]]++;
            }
        }

        for (int j = 0; j < s.Length; j++) {
            if (!uniqueS.ContainsKey(t[j]) || !uniqueT.ContainsKey(s[j])) return false;
            // check frequencies
            if (uniqueS[s[j]] != uniqueT[s[j]]) return false;
        }
        return true;
    }
}
