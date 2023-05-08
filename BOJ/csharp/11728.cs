namespace BOJ
{
    class No_11728
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);

            int[] arr1 = new int[inputs[0]];
            int[] arr2 = new int[inputs[1]];

            inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
            for(int i = 0 ; i < inputs.Length ; i++)
                arr1[i] = inputs[i];

            inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
            for(int i = 0 ; i < inputs.Length ; i++)
                arr2[i] = inputs[i];

            Array.Sort(arr1);
            Array.Sort(arr2);

            int[] merge = new int[arr1.Length + arr2.Length];
            int idx1 = 0, idx2 = 0;
            for(int i=0 ;i< merge.Length ; i++)
            {
                if(idx2 == arr2.Length) merge[i] = arr1[idx1++];
                else if(idx1 == arr1.Length) merge[i] = arr2[idx2++];
                else if(arr1[idx1] < arr2[idx2]) merge[i] = arr1[idx1++];
                else merge[i] = arr2[idx2++];
            }

            for(int i = 0 ; i < merge.Length ; i++)
                output.Write($"{merge[i]} ");
        }
    }
}