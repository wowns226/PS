namespace BOJ
{
    class No_2210
    {
        const int MAX = 5;

        static int[,] board = new int[MAX, MAX];
        static HashSet<string> words = new HashSet<string>();
        static int[] dx = new int[] { 1, 0, -1, 0 };
        static int[] dy = new int[] { 0, 1, 0, -1 };

        static void Main()
        {
            for(int i=0 ;i< MAX;i++)
            {
                int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for(int j=0 ;j< MAX;j++)
                {
                    board[i, j] = inputs[j];
                }
            }

            for(int i = 0 ; i < MAX ; i++)
                for(int j = 0 ; j < MAX ; j++)
                    DFS(i, j, board[i,j].ToString());

            Console.WriteLine(words.Count);
        }

        static void DFS(int x, int y, string word)
        {
            if(word.Length == 6)
            {
                words.Add(word);
                return;
            }

            for(int dir = 0 ; dir < 4 ; dir++)
            {
                int nx = x + dx[dir];
                int ny = y + dy[dir];
                if(nx < 0 || nx >= MAX || ny < 0 || ny >= MAX) continue;

                DFS(nx, ny, word + board[nx, ny].ToString());
            }
        }
    }
}