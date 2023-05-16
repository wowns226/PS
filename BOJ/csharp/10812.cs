namespace BOJ
{
    class No_10812
    {
        public static void Main()
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
                int k = inputs[2];

                arr = Suffle(arr, i, j, k);
            }

            for(int i = 1 ; i <= n ; i++)
                output.Write($"{arr[i]} ");
        }

        static int[] Suffle(int[] arr, int start, int end, int mid)
        {
            int[] clone = new int[arr.Length];
            Array.Copy(arr, clone, arr.Length);

            for(int i=start ;i<=end ;i++)
            {
                clone[i] = arr[mid++];

                if(mid > end)
                {
                    mid = start;
                }
            }

            return clone;
        }
    }
}