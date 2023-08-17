using System;

public class Solution
{
    const int MAX = 50;

    static int answer = MAX;
    static bool[] used = new bool[MAX];

    public int solution(string begin, string target, string[] words)
    {
        DFS(begin, target, words, 0);

        return answer == MAX ? 0 : answer;
    }

    private void DFS(string cur, string target, string[] words, int count)
    {
        if(answer <= count)
        {
            return;
        }

        // 같은 경우 DFS 종료
        if(cur == target)
        {
            answer = Math.Min(answer, count);
            return;
        }


        for(int i=0 ;i<words.Length ;i++)
        {
            // 1자리만 다른 경우
            if(CheckChange(cur, words[i]))
            {
                // 사용하지 않은 경우
                if(!used[i])
                {
                    //Console.WriteLine(words[i]);
                    // 사용 체크
                    used[i] = true;
                    DFS(words[i], target, words, count + 1);
                    used[i] = false;
                }
            }
        }
    }

    private bool CheckChange(string s, string word)
    {
        int count = 0;

        for(int i=0 ;i<s.Length; i++)
            if(s[i] != word[i])
                count++;

        return count == 1 ? true : false;
    }
}