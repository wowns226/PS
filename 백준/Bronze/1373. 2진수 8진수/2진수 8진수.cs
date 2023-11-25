using System.Text;

namespace BOJ_1373
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            string s = Console.ReadLine();

            int length = s.Length;
            int temp = length % 3;
            int i = 0;
            switch (temp)
            {
                case 1:
                    sb.Append(s[0]);
                    i = 1;
                    break;
                case 2:
                    sb.Append((s[0] - '0') * 2 + (s[1] - '0'));
                    i = 2;
                    break;
            }

            for (; i < length; i += 3)
            {
                sb.Append((s[i] - '0') * 4 + (s[i + 1] - '0') * 2 + (s[i + 2] - '0'));
            }

            Console.WriteLine(sb);
        }
    }
}
