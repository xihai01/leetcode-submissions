//using System.Collections.Generic;

public class Solution {
    public bool IsValid(string s) {
        var closingMap = new Dictionary<char, char>
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' },
        };
        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++) {
            // keep track of opening brackets
            if (s[i] == '(' || s[i] == '{' || s[i] == '['){
                stack.Push(s[i]);
            } else {
                // its a closing bracket
                // so compare it with the first element on top of the stack
                // return false if not corresponding bracket
                // otherwise pop off from stack and continue iterating
                if (stack.Count == 0 || stack.Peek() != closingMap[s[i]]) return false;
                stack.Pop();
            }
        }
        return stack.Count == 0;
    }
}