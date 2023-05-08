namespace BOJ
{
    class No_28014
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(input.ReadLine());
            int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);

            int answer = 1;
            for(int i=1 ; i < inputs.Length ;i++)
            {
                if(inputs[i] < inputs[i - 1]) continue;

                answer++;
            }

            output.Write(answer);
        }
    }
}