namespace BOJ
{
    class No_2501
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
            int n = inputs[0];
            int k = inputs[1];

            bool isDone = false;
            int count = 0;
            for(int i=1 ;i<=n ;i++)
            {
                if(n % i == 0)
                {
                    count++;
                }

                if(count == k)
                {
                    output.Write(i);
                    isDone = true;
                    break;
                }
            }

            if(!isDone)
                output.Write(0);
        }
    }
}