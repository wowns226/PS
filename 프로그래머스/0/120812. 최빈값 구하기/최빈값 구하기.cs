using System;
using System.Linq;

public class Solution {
    public int solution(int[] array) {
        int answer = -1;
        
        var groups = array.GroupBy(x => x).Select(g => new { Value = g.Key, Count = g.Count() });

        var maxCount = groups.Max(x=>x.Count);
        var maxCountInGroups = groups.Count(x=>x.Count==maxCount);
        
        if(maxCountInGroups == 1)
        {
            foreach(var item in groups)
            {
                if(item.Count != maxCount) continue;
                
                answer = item.Value;
                break;
            }
        }
        
        return answer;
    }
}