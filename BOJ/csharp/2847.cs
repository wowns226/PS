namespace BOJ
{
    class No_2847
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(input.ReadLine());

            int[] arr = new int[N];

            for(int i=0 ;i<N ;i++)
                arr[i] = int.Parse(input.ReadLine());

            int answer = 0;
            for(int i=N-1 ;i>0 ;i--)
            {
                while(arr[i - 1] >= arr[i])
                {
                    arr[i - 1]--;
                    answer++;
                }
            }

            output.Write(answer);
        }
    }
}