namespace BOJ
{
    class No_15683
    {
        static int N, M, answer;
        static int[,] board;
        static int[,] checkBoard;
        static int[] dx = new int[] { 1, 0, -1, 0 };
        static int[] dy = new int[] { 0, 1, 0, -1 };

        static void Main()
        {
            List<(int, int)> cctvList = new List<(int, int)>();

            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            N = inputs[0];
            M = inputs[1];

            board = new int[N, M];
            checkBoard = new int[N, M];
            answer = N * M;
            for(int i=0 ;i<N ;i++)
            {
                inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for(int j=0 ;j<M ;j++)
                {
                    board[i, j] = inputs[j];

                    if(board[i, j] != 0 && board[i, j] != 6)
                        cctvList.Add((i, j));
                }
            }

            for(int t=0 ;t<(1<<(2*cctvList.Count)) ; t++)
            {
                for(int i = 0 ; i < N ; i++)
                    for(int j = 0 ; j < M ; j++)
                        checkBoard[i, j] = board[i, j];

                int brute = t;
                for(int i=0 ;i<cctvList.Count ; i++)
                {
                    int dir = brute % 4;
                    brute /= 4;
                    int x = cctvList[i].Item1;
                    int y = cctvList[i].Item2;

                    if(board[x, y] == 1)
                    {
                        CheckCCTV(x, y, dir);
                    }
                    else if(board[x, y] == 2)
                    {
                        CheckCCTV(x, y, dir);
                        CheckCCTV(x, y, dir+2);
                    }
                    else if(board[x,y]==3)
                    {
                        CheckCCTV(x, y, dir);
                        CheckCCTV(x, y, dir+1);
                    }
                    else if(board[x, y] == 4)
                    {
                        CheckCCTV(x, y, dir);
                        CheckCCTV(x, y, dir+1);
                        CheckCCTV(x, y, dir+2);
                    }
                    else
                    {
                        CheckCCTV(x, y, dir);
                        CheckCCTV(x, y, dir+1);
                        CheckCCTV(x, y, dir+2);
                        CheckCCTV(x, y, dir+3);
                    }
                }

                int tmp = 0;
                for(int i = 0 ; i < N ; i++)
                    for(int j = 0 ; j < M ; j++)
                        if(checkBoard[i, j] == 0)
                            tmp++;
                    
                answer = Math.Min(answer, tmp);
            }

            Console.Write(answer);
        }

        static void CheckCCTV(int x, int y,int dir)
        {
            dir %= 4;
            while(true)
            {
                x += dx[dir];
                y += dy[dir];

                if(x < 0 || x >= N || y < 0 || y >= M) return;
                if(checkBoard[x, y] == 6) return;
                if(checkBoard[x, y] != 0) continue;

                checkBoard[x, y] = 7;
            }
        }
    }
}


