using System.Text;

namespace BOJ
{
    class No_2720
    {
        static void Main()
        {
            var sb = new StringBuilder();

            var tc = InputToInt();
            while (tc-- > 0)
            {
                var n = InputToInt();

                int a = n / 25;
                n %= 25;
                int b = n / 10;
                n %= 10;
                int c = n / 5;
                n %= 5;
                int d = n;

                sb.AppendLine($"{a} {b} {c} {d}");
            }

            Console.Write(sb);
        }

        static int InputToInt() => int.Parse(Console.ReadLine());
    }
}