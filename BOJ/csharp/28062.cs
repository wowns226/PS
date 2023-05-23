namespace BOJ
{
    class No_28062
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(input.ReadLine());
            int[] arr = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
            List<int> list = new List<int>();

            int sum = 0;
            for(int i=0 ;i<n ;i++)
            {
                if(arr[i] % 2 == 0)
                    sum += arr[i];
                else
                    list.Add(arr[i]);
            }

            list = list.OrderByDescending(x => x).ToList();

            for(int i=0 ;i<(list.Count/2)*2 ;i++)
            {
                sum += list[i];
            }

            output.Write(sum);
        }
    }
}
