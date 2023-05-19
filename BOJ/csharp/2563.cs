namespace BOJ
{
    class No_2563
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            const int COLORPAPER_LENGTH = 10;
            const int BOARD_MAX = 101;

            bool[,] board = new bool[BOARD_MAX, BOARD_MAX];

            int colorPaperNum = int.Parse(input.ReadLine());

            int answer = 0;
            while(colorPaperNum-- > 0)
            {
                int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
                int x = inputs[0];
                int y = inputs[1];

                for(int i = x ; i < x + COLORPAPER_LENGTH ; i++)
                {
                    for(int j = y ; j < y + COLORPAPER_LENGTH ; j++)
                    {
                        if(board[i, j] == true)
                            continue;

                        board[i, j] = true;
                        answer++;
                    }
                }
            }

            output.Write(answer);
        }
    }
}
