namespace Programmers
{
    class No_42861
    {
        static void Main()
        {
            TestCase(4, new int[,] { { 0, 1, 1 }, { 0, 2, 2 }, { 1, 2, 5 }, { 1, 3, 1 }, { 2, 3, 8 } }, 4);
        }

        static void TestCase(int n, int[,] costs, int answer)
        {
            var testCaseValue = Solution(n, costs);

            if(testCaseValue == answer)
                Console.WriteLine("성공");
            else
                Console.WriteLine("실패");
        }

        static int Solution(int n, int[,] costs)
        {
            int[,] distance = new int[n, n];
            int i, j;

            for(i = 0 ; i < n ; i++)
            {
                for(j = 0 ; j < n ; j++)
                {
                    distance[i, j] = -1;
                }
            }
            for(i = 0 ; i < costs.GetLength(0) ; i++)
            {
                distance[costs[i, 0], costs[i, 1]] = costs[i, 2];
                distance[costs[i, 1], costs[i, 0]] = costs[i, 2];
            }
            HashSet<int> ans = new HashSet<int>();
            ans.Add(0);
            int min;
            int minIdx = -1;
            int answer = 0;
            while(ans.Count < n)
            {
                min = 9999999;
                foreach(int it in ans)
                {
                    for(i = 0 ; i < n ; i++)
                    {
                        if(ans.Contains(i))
                            continue;
                        if(distance[it, i] != -1 && distance[it, i] < min)
                        {
                            min = distance[it, i];
                            minIdx = i;
                        }
                    }
                }
                answer += min;
                ans.Add(minIdx);
            }
            return answer;
        }
    }
}