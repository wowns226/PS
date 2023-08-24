namespace BOJ
{
    class No_9019
    {
        static HashSet<int> visited = new HashSet<int>();
        static Queue<(int, string)> q = new Queue<(int, string)>();

        static void Main()
        {
            int testCase = int.Parse(Console.ReadLine());

            while(testCase-->0)
            {
                int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int start = inputs[0];
                int target = inputs[1];

                string answer = BFS(start, target);
                Console.WriteLine(answer);
            }
        }

        static string BFS(int A, int B)
        {
            visited.Clear();
            q.Clear();

            q.Enqueue((A, ""));

            while(q.Count > 0)
            {
                var cur = q.Dequeue();
                int curNum = cur.Item1;
                string curString = cur.Item2;

                if(curNum == B) return curString;
                

                if(!visited.Contains(curNum))
                {
                    visited.Add(curNum);
                    q.Enqueue((D(curNum), curString + "D"));
                    q.Enqueue((S(curNum), curString + "S"));
                    q.Enqueue((L(curNum), curString + "L"));
                    q.Enqueue((R(curNum), curString + "R"));
                }
            }

            return "";
        }

        static int D(int n) => (2 * n) % 10000;
        static int S(int n) => (n - 1 + 10000) % 10000;
        static int L(int n) => (n * 10) % 10000 + n / 1000;
        static int R(int n) => n / 10 + (n % 10) * 1000;
    }
}