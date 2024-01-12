using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(string[,] clothes) {
        int answer = 1;
        
        Dictionary<string, int> dict = new Dictionary<string, int>();
        
        for(int i=0;i<clothes.GetLength(0);i++)
        {
            dict.TryAdd(clothes[i,1], 0);
            dict[clothes[i,1]]++;
        }
        
        foreach(var item in dict)
        {
            answer *= (item.Value + 1);
        }
        
        return answer - 1;
    }
}