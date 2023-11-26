namespace BOJ_26264
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            int index = 0;
            int security = 0;
            int bigdata = 0;
            while (index < s.Length)
            {
                if (s[index] == 's')
                {
                    index += 8;
                    security++;
                }
                else
                {
                    index += 7;
                    bigdata++;
                }
            }

            if (security < bigdata)
            {
                Console.WriteLine("bigdata?");
            }
            else if (security > bigdata)
            {
                Console.WriteLine("security!");
            }
            else
            {
                Console.WriteLine("bigdata? security!");
            }
        }
    }
}
