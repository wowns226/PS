namespace BOJ
{
    class No_2566
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            const int MAX_INDEX = 9;

            int[,] board = new int[MAX_INDEX, MAX_INDEX];

            (int, int) maxIndex = (0, 0);
            int myMax = int.MinValue;
            for(int i = 0 ; i < MAX_INDEX ; i++)
            {
                int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
                for(int j = 0 ; j < MAX_INDEX ; j++)
                {
                    board[i, j] = inputs[j];

                    if(myMax < board[i, j])
                    {
                        myMax = board[i, j];
                        maxIndex = (i + 1, j + 1);
                    }
                }
            }

            output.WriteLine($"{myMax}");
            output.Write($"{maxIndex.Item1} {maxIndex.Item2}");
        }
    }
}
