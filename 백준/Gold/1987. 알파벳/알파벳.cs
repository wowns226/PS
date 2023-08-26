namespace BOJ
{
    class No_1987
    {
        static int R, C;
        static char[,] arr;
        static int[,] board;
        static bool[] used = new bool[26];
        static int answer = 0;
        static int[] dx = new int[] { 1, 0, -1, 0 };
        static int[] dy = new int[] { 0, 1, 0, -1 };

        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);

            R = inputs[0];
            C = inputs[1];

            arr = new char[R, C];
            board = new int[R, C];

            for(int i=0 ;i<R; i++)
            {
                var s = input.ReadLine().ToCharArray();

                for(int j=0 ;j<C; j++)
                    arr[i,j] = s[j];
            }

            used[arr[0, 0] - 'A'] = true;
            DFS(0, 0, 1);

            Console.WriteLine(answer);
        }

        static void DFS(int x, int y, int count)
        {
            answer = Math.Max(answer, count);
            // 백트레킹
            for(int dir=0 ;dir<4 ;dir++)
            {
                int nx = x + dx[dir];
                int ny = y + dy[dir];

                if(nx >= 0 && ny >= 0 && nx < R && ny < C)
                {
                    if(!used[arr[nx, ny] - 'A'])
                    {
                        // 알파벳 사용
                        used[arr[nx, ny] - 'A'] = true;
                        // 다시 진입
                        DFS(nx, ny, count + 1);
                        // 알파벳 사용 여부 복구
                        used[arr[nx, ny] - 'A'] = false;
                    }
                }
                
            }
        }
    }
}