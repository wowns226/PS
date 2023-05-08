namespace BOJ
{
    class No_6359
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int testcase = int.Parse(input.ReadLine());

            while(testcase-->0)
            {
                int n = int.Parse(input.ReadLine());
                bool[] rooms = new bool[n + 1];

                for(int i=1 ;i<n+1 ;i++)
                {
                    int idx = i;
                    while(idx <n+1)
                    {
                        rooms[idx] = !rooms[idx];
                        idx += i;
                    }
                }

                int count = 0;
                for(int i=1 ;i<n+1 ;i++)
                {
                    if(!rooms[i]) continue;

                    count++;
                }

                output.WriteLine(count);
            }
        }
    }
}