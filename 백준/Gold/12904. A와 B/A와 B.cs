namespace BOJ
{
    class No_12904
    {
        static void Main()
        {
            string s = Input();
            string t = Input();
            int answer = 0;

            while (true)
            {
                if (s.Length == t.Length)
                {
                    if (s == t)
                        answer = 1;
                    break;
                }

                if (t[t.Length - 1] == 'A')
                    t = t.Remove(t.Length - 1);
                else
                {
                    t = t.Remove(t.Length - 1);
                    char[] charArray = t.ToCharArray();
                    Array.Reverse(charArray);
                    t = new string(charArray);
                }
            }

            Console.WriteLine(answer);
        }

        static string Input() => Console.ReadLine();
    }
}