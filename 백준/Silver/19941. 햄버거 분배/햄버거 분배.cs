namespace BOJ_19941
{
    class Program
    {
        const char PERSON = 'P';
        const char HAMBURGER = 'H';
        
        static void Main()
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = inputs[0];
            int k = inputs[1];

            string s = Console.ReadLine();
            bool[] eaten = new bool[n];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (s[i] == HAMBURGER) continue;
                
                for (int j = i - k; j <= i + k; j++)
                {
                    if (j < 0) j = 0;
                    if (j >= n) break;
                    if (s[j] == PERSON || eaten[j]) continue;
                    
                    eaten[j] = true;
                    count++;

                    break;
                }
            }

            Console.WriteLine(count);
        }
    }
}
