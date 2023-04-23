namespace BOJ
{
    class Program
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(input.ReadLine());
            while(N-- > 0)
            {
                int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
                int[] arr = new int[inputs[0]];

                for(int i = 0 ; i < inputs[0] ; i++)
                    arr[i] = inputs[i + 1];

                var sortedArr = arr.OrderByDescending(x => x).ToArray();

                long answer = SumGCD(sortedArr);

                output.WriteLine(answer);
            }
        }

        static long SumGCD(int[] arr)
        {
            long sum = 0;
            for(int i = 0 ; i < arr.Length ; i++)
            {
                for(int j = i + 1 ; j < arr.Length ; j++)
                {
                    sum += GCD(arr[i], arr[j]);
                }
            }

            return sum;
        }

        static long GCD(int x, int y)
        {
            if(y == 0)
                return x;

            return GCD(y, x % y);
        }
    }
}
