namespace cs
{
    class No_43165
    {
        static void Main()
        {
            Console.WriteLine(TestCase(6, new int[,] { { 3, 6 }, { 4, 3 }, { 3, 2 }, { 1, 3 }, { 1, 2 }, { 2, 4 }, { 5, 2 } }, 3));
        }

        static string TestCase(int n, int[,] edge, int returnValue)
        {
            int testCaseValue = Solution(n, edge);

            if(testCaseValue == returnValue)
                return "성공";

            return "실패";
        }

        static int Solution(int n, int[,] edge)
        {
            int answer = 0;
            Queue<int>[] q = new Queue<int>[n+1];
            for(int i=1 ;i<=n ;i++)
                q[i] = new Queue<int>();
            

            for(int i=0 ;i<edge.GetLength(0) ;i++)
            {
                q[edge[i, 0]].Enqueue(edge[i,1]);
                q[edge[i, 1]].Enqueue(edge[i,0]);
            }

            Queue<(int, int)> tmp = new Queue<(int, int)>();
            int[] arr = new int[n + 1];

            tmp.Enqueue((1, 0));

            while(tmp.Count > 0)
            {
                var cur = tmp.Dequeue();

                int idx = cur.Item1;
                int cnt = cur.Item2;

                while(q[idx].Count>0)
                {
                    int curIdx = q[idx].Dequeue();

                    tmp.Enqueue((curIdx, cnt + 1));
                }

                if(idx == 1) continue;

                if(arr[idx] == 0)
                    arr[idx] = cnt;
                else
                    arr[idx] = Math.Min(arr[idx], cnt);
            }

            int max = arr.Max();

            Console.WriteLine(max);
            answer = arr.Count(x => x == max);

            return answer;
        }
    }
}