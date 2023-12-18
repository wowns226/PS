using System.Text;

namespace BOJ_9935
{
    class Program
    {

        static void Main()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            StringBuilder t = new StringBuilder();

            for (int i = 0; i < a.Length; i++)
            {
                t.Append(a[i]);
                if (t.Length >= b.Length)
                {
                    bool flag = true;
                    for (int j = 0; j < b.Length; j++)
                    {
                        if (t[t.Length - b.Length + j] != b[j])
                        {
                            flag = false;
                            break;
                        }
                    }

                    if (flag)
                    {
                        t.Length -= b.Length;
                    }
                }
            }

            if (t.Length == 0)
            {
                Console.WriteLine("FRULA");
            }
            else
            {
                Console.WriteLine(t);
            }
        }
    }
}
