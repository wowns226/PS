using System;
using System.Linq;

public class Solution {
    public int solution(int a, int b) {
        string A = a.ToString();
        string B = b.ToString();
        
        int ab = int.Parse(A+B);
        int ba = int.Parse(B+A);
        
        return Math.Max(ab,ba);
    }
}