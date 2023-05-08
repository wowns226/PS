namespace BOJ
{
    class No_1920
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(input.ReadLine());
            int[] arr1 = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
            int m = int.Parse(input.ReadLine());
            int[] arr2 = Array.ConvertAll(input.ReadLine().Split(), int.Parse);

            Array.Sort(arr1);

            for(int i=0 ;i<arr2.Length ;i++)
            {
                bool isExist = false;
                int start = 0;
                int end = arr1.Length-1;
                while(start <= end)
                {
                    int mid = (start + end) / 2;

                    if(arr2[i] == arr1[mid])
                    {
                        isExist = true;
                        break;
                    }

                    if(arr2[i] < arr1[mid])
                        end = mid - 1;
                    else
                        start = mid + 1;
                }

                if(isExist)
                {
                    output.WriteLine(1);
                }
                else
                {
                    output.WriteLine(0);
                }
            }
        }
    }
}