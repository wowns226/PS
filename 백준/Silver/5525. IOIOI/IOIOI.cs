namespace BOJ
{
    class No_5525
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int nLength = n * 2 + 1;

            int answer = 0;
            for (int i = 0; i <= m - nLength; i++)
            {
                if(s[i] == 'O') continue;

                int count = 0;
                for (int j = 0; j < nLength; j++)
                {
                    if (j % 2 == 0 && s[i+j] != 'I')
                    {
                        break;
                    }
                    
                    if (j % 2 == 1 && s[i+j] != 'O')
                    {
                        break;
                    }

                    count++;
                }
                
                if (count == nLength)
                {
                    answer++;
                }
            }

            Console.WriteLine(answer);
        }
    }   
}