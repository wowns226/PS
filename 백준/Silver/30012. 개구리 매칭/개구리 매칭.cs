namespace BOJ_30012
{
    class Program
    {
        static void Main()
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int s = inputs[0];
            int n = inputs[1];
            int[] frogs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int k = inputs[0];
            int l = inputs[1];

            int min = int.MaxValue;
            int frog = 0;
            int len;

            for(int i=0 ;i<n ;i++)
            {
                if(Math.Abs(frogs[i] - s) <= 2 * k)
                    len = 2 * k - Math.Abs(frogs[i] - s);
                else
                    len = (Math.Abs(frogs[i] - s) - 2 * k) * l;

                if(len < min)
                {
                    min = len;
                    frog = i + 1;
                }
            }

            Console.WriteLine($"{min} {frog}");
        }
    }
}
