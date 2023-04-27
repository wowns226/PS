namespace BOJ
{
    class No_13414
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);

            int k = inputs[0];
            int l = inputs[1];

            Dictionary<string, int> dict = new Dictionary<string, int>();

            for(int i=1 ;i<=l ;i++)
            {
                string id = input.ReadLine();

                if(!dict.ContainsKey(id))
                    dict.Add(id, i);
                else
                    dict[id] = i;
            }

            var sorted = dict.OrderBy(x => x.Value).Select(x => x.Key).ToList();

            for(int i=0 ;i<k ;i++)
            {
                if(sorted.Count <= i)
                    break;

                output.WriteLine(sorted[i]);
            }
        }
    }
}