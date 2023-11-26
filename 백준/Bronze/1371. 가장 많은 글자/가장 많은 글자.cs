namespace BOJ_1371
{
    class Program
    {
        static void Main()
        {
            int[] alp = new int[27];
            int max = int.MinValue;

            string line = "";
            while (true)
            {
                line = Console.ReadLine();

                if (line == null) break;

                foreach (int index in line.Select(t => t - 'a').Where(index => index >= 0 && index < alp.Length))
                {
                    alp[index]++;
                    max = Math.Max(max, alp[index]);
                }
            }

            for (int i = 0; i < 27; i++)
            {
                if (alp[i] == max)
                {
                    Console.Write((char)(i + 'a'));
                }
            }
        }
    }
}
