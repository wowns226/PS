using System.Text;
namespace BOJ_2776
{
    class Program
    {
        static void Main()
        {
            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            StringBuilder sb = new StringBuilder();

            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            
            int T = int.Parse(sr.ReadLine());
            while (T-- > 0)
            {
                int N = int.Parse(sr.ReadLine());
                list1 = sr.ReadLine().Split().Select(int.Parse).ToList();

                int M = int.Parse(sr.ReadLine());
                list2 = sr.ReadLine().Split().Select(int.Parse).ToList();

                list1.Sort();

                for (int i = 0; i < M; i++)
                {
                    sb.AppendLine(BinarySearch(list2[i], list1));
                }
            }

            sw.Write(sb);
        }

        static string BinarySearch(int target, List<int> list)
        {
            int start = 0;
            int end = list.Count - 1;

            while (start <= end)
            {
                int mid = (start + end) >> 1;

                if (list[mid] < target)
                {
                    start = mid + 1;
                }
                else if(list[mid] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    return "1";
                }
            }

            return "0";
        }
    }
}
