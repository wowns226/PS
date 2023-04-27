namespace BOJ
{
    class No_11501
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int t = int.Parse(input.ReadLine());

            while(t-->0)
            {
                int n = int.Parse(input.ReadLine());

                int[] stocks = Array.ConvertAll(input.ReadLine().Split(), int.Parse);

                long benefit = 0;
                int maxStock = 0;

                for(int day = n-1 ; day >= 0; day--)
                {
                    if(stocks[day] < maxStock)
                        benefit += (maxStock - stocks[day]);
                    else
                        maxStock = stocks[day];
                }
                
                output.WriteLine(benefit);
            }
        }
    }
}