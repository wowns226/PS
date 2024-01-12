using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] genres, int[] plays) {            
            int Length = genres.Length;
        
            Dictionary<string, List<KeyValuePair<int, int>>> dict = new Dictionary<string, List<KeyValuePair<int, int>>>();
        
            for(int i=0;i<Length;i++)
            {
                dict.TryAdd(genres[i], new List<KeyValuePair<int, int>>());
                dict[genres[i]].Add(new KeyValuePair<int, int>(plays[i], i));
            }
        
            List<int> list = new List<int>();
            foreach(var item in dict.OrderByDescending(x=>x.Value.Sum(y=>y.Key)))
            {
                var t = item.Value.OrderByDescending(x=> x.Key).ToList();
                for(int i=0;i<2;i++)
                {
                    if(t.Count <= i) break;
                    
                    list.Add(t[i].Value);
                }
            }
        
            return list.ToArray();
    }
}