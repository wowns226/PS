namespace BOJ_18111
{
    class Program
    {
        static void Main()
        {
            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int n = inputs[0];
            int m = inputs[1];
            int b = inputs[2];

            int[,] board = new int[n, m];
            int minHeight = int.MaxValue;
            int maxHeight = int.MinValue;
            
            for (int i = 0; i < n; i++)
            {
                inputs = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                for (int j = 0; j < m; j++)
                {
                    board[i, j] = inputs[j];

                    minHeight = Math.Min(board[i, j], minHeight);
                    maxHeight = Math.Max(board[i, j], maxHeight);
                }
            }

            int[,] tempBoard = new int[n, m];
            
            int answerTime = int.MaxValue;
            int answerHeight = 0;
            for (int height = minHeight; height <= maxHeight; height++)
            {
                int inventory = b;
                int time = 0;
                
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (board[i, j] == height) continue;

                        int gap = board[i, j] - height;

                        if (gap > 0)
                        {
                            inventory += gap;
                            time += gap * 2;
                        }
                        else
                        {
                            inventory += gap;
                            time -= gap;
                        }
                    }
                }

                if (inventory < 0) continue;
                
                if (time < answerTime)
                {
                    answerTime = time;
                    answerHeight = height;
                }
                else if (time == answerTime)
                {
                    answerHeight = Math.Max(answerHeight, height);
                }
            }
            
            sw.Write($"{answerTime} {answerHeight}");
        }
    }
}
