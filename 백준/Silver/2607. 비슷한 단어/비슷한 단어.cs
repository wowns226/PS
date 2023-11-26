namespace BOJ_2607
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();

            int[] alp = new int[27];
            int[] temp = new int[27];
            
            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }
            
            for (int x = 0; x < list[0].Length; x++)
            {
                alp[list[0][x] - 'A']++;
            }
            
            int answer = 0;
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < 27; j++)
                {
                    temp[j] = alp[j];
                }
                
                for (int j = 0; j < list[i].Length; j++)
                {
                    temp[list[i][j] - 'A']--;
                }

                int diff = 0;
                for (int j = 0; j < 27; j++)
                {
                    diff += Math.Abs(temp[j]);
                }
                
                if (diff <= 1)
                {
                    answer++;
                }
                else if (diff == 2 && list[0].Length == list[i].Length)
                {
                    answer++;
                }
            }
            Console.WriteLine(answer);
        }
    }
}
