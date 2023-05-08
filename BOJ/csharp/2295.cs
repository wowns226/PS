namespace BOJ
{
    class No_2295
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(input.ReadLine());
            int[] arr = new int[n];
            
            for(int i=0 ;i<n ;i++)
                arr[i] = int.Parse(input.ReadLine());

            Array.Sort(arr);

            List<int> two = new List<int>();
            for(int i=0 ;i<n ;i++)
                for(int j=i ;j<n ;j++)
                    two.Add(arr[i] + arr[j]);

            two.Sort();

            for(int i=n-1 ;i>0 ;i--)
            {
                for(int j=0 ;j<i ;j++)
                {
                    if(BinarySearch(two, arr[i] - arr[j]))
                    {
                        output.Write(arr[i]);
                        return;
                    }
                }
            }
        }

        static bool BinarySearch(List<int> list, int target)
        {
            int start = 0;
            int end = list.Count-1;

            while(start<=end)
            {
                int mid = (start+end)/2;

                if(list[mid] == target)
                    return true;
                else if(list[mid] < target)
                    start = mid + 1;
                else
                    end = mid - 1;
            }

            return false;
        }
    }
}