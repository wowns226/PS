namespace cs
{
    class No_14921
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(input.ReadLine());
            int[] arr = Array.ConvertAll(input.ReadLine().Split(), int.Parse);

            Array.Sort(arr);

            int start = 0;
            int end = n - 1;
            int min = Math.Abs(arr[end] + arr[start]);
            int answer = arr[end] + arr[start];

            while(start < end)
            {
                int val = arr[start] + arr[end];
                if(Math.Abs(val) < min)
                {
                    min = Math.Abs(val);
                    answer = val;
                }

                if(val < 0)
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }

            output.Write(answer);
        }
    }
}