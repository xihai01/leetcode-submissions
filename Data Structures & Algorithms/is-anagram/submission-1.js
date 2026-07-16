class Solution {
    /**
     * @param {string} s
     * @param {string} t
     * @return {boolean}
     */
    isAnagram(s, t) {
        if (s.length !== t.length) {
            return false;
        }
        // store the frequency of letters for each string in a hash and then compare using moduluo
        const hashS = {};
        const hashT = {};

        for (let i = 0; i < s.length; i++) {
            hashS[s[i]] !== undefined ? hashS[s[i]] += 1 : hashS[s[i]] = 1;
            hashT[t[i]] !== undefined ? hashT[t[i]] += 1 : hashT[t[i]] = 1;
        }
console.log(hashS);
console.log(hashT);
    

        // compare letters in s to hasht
        // compare letters in t to hashS
        let lengthS = s.length;
        let lengthT = t.length;
        for (let i = 0; i < s.length; i++) {
            if (hashT[s[i]] !== undefined && hashT[s[i]] !== 0) {
                hashT[s[i]] -= 1;
                lengthS -= 1;
            }
            if (hashS[t[i]] !== undefined && hashS[t[i]] !== 0) {
                hashS[t[i]] -= 1;
                lengthT -= 1;
            }
        }

       console.log(hashS);
console.log(hashT);

        if (lengthS === 0) return true;
        if (lengthT === 0) return true;

        return false;

    }
}
