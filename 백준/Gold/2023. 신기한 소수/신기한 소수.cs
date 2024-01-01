using System.Text;

namespace BOJ
{    
    class No_2023
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            int[] prime = { 2, 3, 5, 7 };
            for (int i = 0; i < 4; i++)
            {
                Recursive(prime[i], n - 1, sb);
            }

            Console.Write(sb);
        }

        static void Recursive(int first, int n, StringBuilder sb)
        {
            if (n == 0)
            {
                sb.AppendLine($"{first}");
            }

            for (int i = 1; i < 10; i += 2)
            {
                int temp = first * 10 + i;
                if (IsPrime(temp))
                {
                    Recursive(temp, n - 1, sb);
                }
            }
        }

        static bool IsPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}