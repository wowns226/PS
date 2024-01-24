using System;
using System.Linq;

public class Solution {
    public int solution(int[] array) {        
        return array.OrderBy(x=>x).ToList()[array.Length>>1];
    }
}