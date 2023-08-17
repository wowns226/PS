using System;

public class Solution {
    
    const int MAX = 202;
    static bool[] visited = new bool[MAX];
    
    public int solution(int n, int[,] computers)
        {
            int answer = 0;

            for(int i=0 ;i<n ;i++)
            {
                if(!visited[i])
                {
                    DFS(i, n, computers);
                    answer++;
                }
            }

            return answer;
        }

        public void DFS(int idx, int n, int[,] computers)
        {
            visited[idx] = true;

            for(int i=0 ;i<n ;i++)
            {
                if(!visited[i] && computers[idx, i] == 1)
                    DFS(i, n, computers);
            }
        }
}