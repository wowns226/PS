namespace BOJ
{
    class No_2999
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string s = input.ReadLine();
            int length = s.Length;

            int r = 0, c = 0;
            for(int i=1 ;i<= length;i++)
            {
                for(int j=1 ;j<=length ;j++)
                {
                    if(i*j == length)
                    {
                        if(i<=j)
                        {
                            r = i;
                            c = j;
                        }
                    }
                }
            }
            char[,] board = new char[r, c];
            int idx = 0;
            for(int i=0 ;i<c ;i++)
            {
                for(int j = 0;j < r;j++)
                {
                    board[j, i] = s[idx++];
                }
            }

            for(int i = 0 ; i < r ; i++)
            {
                for(int j = 0 ; j < c ; j++)
                {
                    output.Write(board[i, j]);
                }
            }
        }
    }
}