namespace BOJ
{
    class No_2003
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
            int n = inputs[0];
            int m = inputs[1];

            int[] arr = new int[10001];
            inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
            for(int i = 0 ; i < n ; i++)
                arr[i] = inputs[i];

            int cnt = 0;
            int sum = 0;
            int st = 0;
            int en = 0;
            while(en <= n)
            {
                if(sum < m)
                {
                    sum += arr[en];
                    en++;
                }
                else
                {
                    if(sum == m)
                        cnt++;

                    sum -= arr[st];
                    st++;
                }
            }

            output.Write(cnt);
        }
    }
}