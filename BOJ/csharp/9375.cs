namespace BOJ
{
    class No_9375
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int t = int.Parse(input.ReadLine());
            
            while(t-->0)
            {
                int n = int.Parse(input.ReadLine());
                Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

                int answer = 1;
                while(n-->0)
                {
                    string[] inputs = input.ReadLine().Split();

                    if(!dict.ContainsKey(inputs[1]))
                    {
                        dict.Add(inputs[1], new List<string>());
                        dict[inputs[1]].Add(inputs[0]);
                    }
                    else
                    {
                        dict[inputs[1]].Add(inputs[0]);
                    }
                }

                foreach(var dic in dict)
                    answer *= dic.Value.Count + 1;
                

                output.WriteLine(answer - 1);
            }
           
        }
    }
}