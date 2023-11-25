namespace BOJ_2428
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] files = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            
            Array.Sort(files);

            long answer = 0;
            for (int i = 1; i < n; i++)
            {
                answer += BinarySearch(i, files);
            }

            Console.WriteLine(answer);
        }

        static long BinarySearch(int index, int[] files)
        {
            int start = 0;
            int end = index - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (files[mid] < files[index] * 0.9)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return index - start;
        }
    }
}
