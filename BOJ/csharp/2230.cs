namespace BOJ
{
    class No_2230
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
            int n = inputs[0];
            int m = inputs[1];
            int[] arr = new int[n];
            for(int i = 0 ; i < n ; i++)
                arr[i] = int.Parse(input.ReadLine());

            Array.Sort(arr);

            int en = 0;
            int mn = int.MaxValue;
            for(int st = 0 ;st<n ;st++)
            {
                while(en < n && arr[en] - arr[st] < m)
                    en++;

                if(en == n)
                    break;

                mn = Math.Min(mn, arr[en] - arr[st]);
            }

            output.Write(mn);
        }
    }
}