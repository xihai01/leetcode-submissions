class Solution {
    /**
     * @param {string} s
     * @return {boolean}
     */
    isPalindrome(s) {
        // clean up string - remove any non-alpha characters
        // use two pointers - a point to first char and b point to last char
        // in a loop, compare the two char pointed by a and b
        // if matches, a++, b--
        // if no match, return false
        // stop loop when a over shoots b
        // end of loop means palindrome so return true
        const cleanStr = s.replace(/[^a-zA-Z0-9]/g, '');
        console.log(cleanStr);
        let a = 0; //2
        let b = cleanStr.length - 1; //4
        while (a <= b) {
            const char1 = cleanStr[a].toLowerCase();
            const char2 = cleanStr[b].toLowerCase();
            if (char1 !== char2) {
                return false;
            }
            a += 1;
            b -= 1;
        }
        return true;
    }
}
