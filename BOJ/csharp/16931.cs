namespace BOJ
{
    class No_16931
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] dx = { 1, 0, -1, 0 };
            int[] dy = { 0, 1, 0, -1 };

            int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
            int n = inputs[0];
            int m = inputs[1];

            int[,] arr = new int[n, m];

            for(int i=0 ;i<n ;i++)
            {
                inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
                for(int j=0 ;j<m ;j++)
                {
                    arr[i, j] = inputs[j];
                }
            }

            int totalSum = 0;
            for(int i=0 ;i<n ;i++)
            {
                for(int j=0 ;j<m ;j++)
                {
                    int sum = 0;
                    sum += (arr[i, j] * 4 + 2);

                    int minus = 0;
                    (int, int) cur = (i, j);
                    for(int dir=0 ;dir<4 ;dir++)
                    {
                        int nx = cur.Item1 + dx[dir];
                        int ny = cur.Item2 + dy[dir];

                        if(nx < 0 || ny < 0 || nx >= n || ny >= m) continue;

                        minus += Math.Min(arr[i, j], arr[nx, ny]);
                    }

                    sum -= minus;
                    totalSum += sum;
                }
            }

            output.Write(totalSum);
        }
    }
}
