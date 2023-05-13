namespace BOJ
{
    class No_10810
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
            int n = inputs[0];
            int m = inputs[1];

            int[] arr = new int[n];

            while(m-->0)
            {
                inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
                int i = inputs[0]-1;
                int j = inputs[1]-1;
                int k = inputs[2];

                for(int t = i ; t <= j ; t++)
                    arr[t] = k;
            }

            for(int i = 0 ; i < n ; i++)
                output.Write($"{arr[i]} ");
        }
    }
}
