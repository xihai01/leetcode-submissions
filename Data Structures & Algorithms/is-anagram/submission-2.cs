public class Solution {
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
