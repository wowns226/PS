namespace BOJ
{
    class No_2559
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
            int n = inputs[0];
            int k = inputs[1];

            inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
            int sum = 0;
            for(int i = 0 ; i < k ; i++)
                sum += inputs[i];

            int myMax = sum;
            
            for(int i=k ;i<n ;i++)
            {
                sum += inputs[i] - inputs[i - k];
                myMax = Math.Max(sum, myMax);
            }

            output.Write(myMax);
        }
    }
}