namespace BOJ
{
    class No_10815
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(input.ReadLine());
            int[] cards = Array.ConvertAll(input.ReadLine().Split(), int.Parse);

            Array.Sort(cards);

            int m = int.Parse(input.ReadLine());
            int[] answer = Array.ConvertAll(input.ReadLine().Split(), int.Parse);

            for(int i = 0 ; i < m ; i++)
                output.Write($"{BinarySearch(cards, answer[i])} ");
        }

        static int BinarySearch(int[] arr, int num)
        {
            int start = 0;
            int end = arr.Length - 1;

            while(start <= end)
            {
                int mid = (start + end) / 2;

                if(arr[mid] == num)
                    return 1;

                if(arr[mid] < num)
                    start = mid + 1;
                else
                    end = mid - 1;
            }

            return 0;
        }
    }
}