namespace BOJ
{
    class No_11403
    {
        const int MAX = 102;

        static int n;
        static int[,] board = new int[MAX, MAX];
        static int[,] answer = new int[MAX, MAX];
        static bool[] visited = new bool[MAX];
        static Queue<(int, int)> q = new Queue<(int, int)>();

        static void Main()
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            n = inputs[0];

            for(int i=0 ;i<n ;i++)
            {
                inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for(int j=0 ;j<n ;j++)
                {
                    board[i, j] = inputs[j];
                }
            }

            for(int i = 0 ; i < n ; i++)
            {
                for(int k = 0 ; k < n ; k++)
                    visited[k] = false;

                for(int j = 0 ; j < n ; j++)
                {
                    if (board[i, j] == 1)
                    {
                        q.Enqueue((i,j));
                        answer[i, j] = 1;

                        while(q.Count > 0)
                        {
                            var cur = q.Dequeue();
                            var curFrom = cur.Item1;
                            var curTo = cur.Item2;

                            for(int k=0 ;k<n ;k++)
                            {
                                if(board[curTo, k] == 0) continue;
                                if(visited[k]) continue;

                                q.Enqueue((curTo, k));
                                visited[k] = true;
                                answer[i, k] = 1;
                            }
                        }
                    }
                }
            }

            for(int i = 0 ; i < n ; i++)
            {
                for(int j = 0 ; j < n ; j++)
                {
                    Console.Write($"{answer[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}