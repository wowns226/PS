namespace BOJ
{
    class No_1269
    {
        static void Main()
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int c1 = inputs[0];
            int c2 = inputs[1];

            HashSet<int> hs1 = new HashSet<int>();
            HashSet<int> hs2 = new HashSet<int>();

            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < c1; i++)
            {
                hs1.Add(int.Parse(input[i]));
            }
            
            input = Console.ReadLine().Split();
            for (int i = 0; i < c2; i++)
            {
                hs2.Add(int.Parse(input[i]));
            }

            int answer = 0;
            HashSet<int> hs = new HashSet<int>();
            foreach (int item in hs1.Where(item => hs2.Contains(item) == false))
            {
                hs.Add(item);
            }

            answer += hs.Count;
            hs.Clear();
            
            foreach (int item in hs2.Where(item => hs1.Contains(item) == false))
            {
                hs.Add(item);
            }
            
            answer += hs.Count;

            Console.WriteLine(answer);
        }
    }
}