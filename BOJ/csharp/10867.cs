namespace BOJ
{
    class No_10867
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            HashSet<int> hashSet = new HashSet<int>();

            int n = int.Parse(input.ReadLine());

            int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
            for(int i = 0 ; i < inputs.Length ; i++)
                hashSet.Add(inputs[i]);
            
            var sorted = hashSet.OrderBy(x => x).ToList();

            foreach(int i in sorted)
                output.Write($"{i} ");
        }
    }
}