namespace BOJ_18110
{
    class Program
    {
        static void Main()
        {
            float n = float.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                list.Add(num);
            }
            
            if(n == 0)
            {
                Console.WriteLine(0);
                return;
            }
            
            list.Sort();
            
            float val = (n * 15) / 100;
            int cutLine;
            if (val - (int)val < 0.5f)
                cutLine = (int)val;
            else
                cutLine = (int)val + 1;

            float sum = 0;
            for (int i = cutLine; i < list.Count - cutLine; i++)
                sum += list[i];

            val = sum / (list.Count - (2 * cutLine));

            int ans;
            if (val - (int)val < 0.5f)
                ans = (int)val;
            else
                ans = (int)val + 1;

            Console.WriteLine(ans);
        }
    }
}
