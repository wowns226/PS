namespace BOJ
{
    class No_15903
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            long[] inputs = Array.ConvertAll(input.ReadLine().Split(), long.Parse);

            long N = inputs[0];
            long M = inputs[1];

            inputs = Array.ConvertAll(input.ReadLine().Split(), long.Parse);

            Array.Sort(inputs);

            while(M-->0)
            {
                long sum = inputs[0] + inputs[1];
                inputs[0] = sum;
                inputs[1] = sum;

                Array.Sort(inputs);
            }

            long answer = 0;
            for(int i = 0 ; i < N ; i++)
                answer += inputs[i];

            output.Write(answer);
        }
    }
}