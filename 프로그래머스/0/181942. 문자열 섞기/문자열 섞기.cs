using System;
using System.Text;

public class Solution {
    public string solution(string str1, string str2) {
        StringBuilder sb = new StringBuilder();
        
        int len = str1.Length;
        for(int i=0;i<len;i++)
        {
            sb.Append(str1[i]);
            sb.Append(str2[i]);
        }
        
        return sb.ToString();
    }
}