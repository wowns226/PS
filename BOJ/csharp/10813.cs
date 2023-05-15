namespace BOJ
{
    class No_10813
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
            int n = inputs[0];
            int m = inputs[1];

            int[] arr = new int[n + 1];

            for(int i = 1 ; i <= n ; i++)
                arr[i] = i;

            while(m-->0)
            {
                inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);

                int i = inputs[0];
                int j = inputs[1];

                int temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;
            }

            for(int i = 1 ; i <= n ; i++)
                output.Write($"{arr[i]} ");
        }
    }
}
