namespace BOJ
{
    class No_3036
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(input.ReadLine());
            int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
            
            for(int i=1 ;i<n; i++)
            {
                int gcd = GCD(inputs[0], inputs[i]);
                output.WriteLine($"{inputs[0] / gcd}/{inputs[i] / gcd}");
            }
        }

        static int GCD(int a, int b)
        {
            if(b == 0)
                return a;

            return GCD(b, a % b);
        }
    }
}