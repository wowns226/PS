using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] priorities, int location) {
        int answer = 0;
        Queue<(int, int)> q = new Queue<(int, int)>();
        for(int i = 0 ; i < priorities.Length ; i++)
        {
            q.Enqueue((i, priorities[i]));
        }
        // (2,0) , (1,1) , (3,2) , (2,3)

        while(true)
        {
            int myMax = q.Max(x=>x.Item2);

            var cur = q.Dequeue();

            if(cur.Item2 == myMax)
            {
                if(cur.Item1 == location)
                    return answer + 1;
                else
                {
                    answer++;
                    continue;
                }
            }

            q.Enqueue(cur);
        }
    }
}