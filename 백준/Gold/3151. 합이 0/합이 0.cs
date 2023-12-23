using System.Text;

namespace BOJ
{
    class No_3151
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Array.Sort(array);

            long answer = ThreeSumCount(array);

            Console.WriteLine(answer);
        }
        
        static long ThreeSumCount(int[] arr)
        {
            long count = 0;
            int n = arr.Length;

            for (int i = 0; i < n - 2; i++)
            {
                for (int j = i + 1; j < n - 1; j++)
                {
                    int target = -(arr[i] + arr[j]);
                    int lowerIndex = LowerBinarySearch(arr, target, j + 1, n - 1);
                    int upperIndex = UpperBinarySearch(arr, target, j + 1, n - 1);

                    if (lowerIndex != -1 && upperIndex != -1)
                    {
                        count += (upperIndex - lowerIndex + 1);
                    }
                }
            }

            return count;
        }

        static int LowerBinarySearch(int[] arr, int target, int x, int y)
        {
            int start = x;
            int end = y;
            int result = -1;

            while (start <= end)
            {
                int mid = (start + end) >> 1;

                if (arr[mid] >= target)
                {
                    result = mid;
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return result;
        }

        static int UpperBinarySearch(int[] arr, int target, int x, int y)
        {
            int start = x;
            int end = y;
            int result = -1;

            while (start <= end)
            {
                int mid = (start + end) >> 1;

                if (arr[mid] <= target)
                {
                    result = mid;
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return result;
        }
    }   
}