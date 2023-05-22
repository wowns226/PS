namespace BOJ
{
    class No_28061
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(input.ReadLine());
            int[] arr = Array.ConvertAll(input.ReadLine().Split(), int.Parse);

            int answer = 0;
            for(int i=0 ;i<n ;i++)
            {
                answer = Math.Max(answer, arr[i] - (n - i));
            }

            output.Write(answer);
        }
    }
}
