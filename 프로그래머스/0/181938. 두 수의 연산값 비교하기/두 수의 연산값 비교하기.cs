using System;
using System.Linq;

public class Solution {
    public int solution(int a, int b) {
        string A = a.ToString();
        string B = b.ToString();
        
        return Math.Max(int.Parse(A+B), 2 * a * b);
    }
}