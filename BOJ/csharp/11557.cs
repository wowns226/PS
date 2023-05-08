namespace BOJ
{
    class No_11557
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int testCase = int.Parse(input.ReadLine());

            while(testCase-->0)
            {
                int n = int.Parse(input.ReadLine());
                List<(string, int)> list = new List<(string, int)>();

                while(n-- > 0)
                {
                    string[] inputs = input.ReadLine().Split();
                    string name = inputs[0];
                    int cost = int.Parse(inputs[1]);

                    list.Add((name, cost));
                }

                var sorted = list.OrderByDescending(x => x.Item2).ToList();

                output.WriteLine(sorted[0].Item1);
            }
        }
    }
}