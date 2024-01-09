namespace BOJ
{
    class No_12933
    {
        static List<List<char>> list = new List<List<char>>();
        
        static void Main()
        {
            bool IsFail = false;
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                IsFail = true;
                char cur = s[i];

                if (list.Count == 0)
                {
                    if (cur == 'q')
                    {
                        list.Add(new List<char>() { 'q' });
                        IsFail = false;
                    }
                }
                else
                {
                    IsFail &= Function(cur, 'q', 0);
                    IsFail &= Function(cur, 'u', 1);
                    IsFail &= Function(cur, 'a', 2);
                    IsFail &= Function(cur, 'c', 3);
                    IsFail &= Function(cur, 'k', 4);
                }

                if (IsFail)
                {
                    break;
                }
            }

            if (list.Any(t => t.Count % 5 != 0))
            {
                Console.WriteLine("-1");
                    
                return;
            }

            if (IsFail == true)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(list.Count);
            }
        }

        static bool Function(char cur, char key, int num)
        {
            if (cur == key)
            {
                foreach (List<char> t in list.Where(t => t.Count % 5 == num))
                {
                    t.Add(cur);

                    return false;
                }
            }

            if (cur != 'q' || key != 'q') return true;
            
            
            list.Add(new List<char>() { 'q' });

            return false;

        }
    }
}