namespace BOJ_19941
{
    class Program
    {
        static void Main()
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = inputs[0];
            int k = inputs[1];

            string s = Console.ReadLine();

            bool[] eaten = new bool[n];
            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'P')
                {
                    eaten[i] = true;
                }
            }

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (s[i] != 'P') continue;
                
                for (int j = i - k; j <= i + k; j++)
                {
                    if (j < 0 || j >= n) continue;
                    if (s[j] != 'H' || eaten[j] != false) continue;
                    
                    eaten[j] = true;
                    count++;

                    break;
                }
            }

            Console.WriteLine(count);
        }
    }
}
