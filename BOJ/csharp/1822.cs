namespace BOJ
{
    class No_1822
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
            int ACount = inputs[0];
            int BCount = inputs[1];

            int[] arrA = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
            int[] arrB = Array.ConvertAll(input.ReadLine().Split(), int.Parse);

            Array.Sort(arrA);
            Array.Sort(arrB);

            List<int> answer = new List<int>();

            for(int i=0 ;i<ACount ;i++)
                if(!BinarySearch(arrB, arrA[i]))
                    answer.Add(arrA[i]);

            output.WriteLine(answer.Count);

            foreach(var i in answer)
                output.Write($"{i} ");
        }

        static bool BinarySearch(int[] arr, int num)
        {
            int start = 0;
            int end = arr.Length - 1;

            while(start <= end)
            {
                int mid = (start + end) / 2;

                if(arr[mid] == num)
                    return true;

                if(arr[mid] < num)
                    start = mid + 1;
                else
                    end = mid - 1;
            }

            return false;
        }
    }
}