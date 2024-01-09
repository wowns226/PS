using System.Text;

namespace BOJ
{
    class No_9506
    {        
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            
            while (true)
            {
                int n = InputToInt();

                if (n == -1)
                {
                    break;
                }

                CheckPerfectNumber(n, sb);
            }

            Console.Write(sb);
        }

        static void CheckPerfectNumber(int num, StringBuilder sb)
        {
            var divisores = GetDivisores(num);

            if (divisores == null)
            {
                sb.AppendLine($"{num} is NOT perfect.");
            }
            else
            {
                sb.Append($"{num} = ");
                for (int i = 0; i < divisores.Count; i++)
                {
                    if (i == divisores.Count - 1)
                    {
                        sb.Append($"{divisores[i]}\n");
                    }
                    else
                    {
                        sb.Append($"{divisores[i]} + ");
                    }
                }
            }
        }

        static List<int>? GetDivisores(int num)
        {
            List<int> list = new List<int> { 1 };

            int sum = 0;
            for (int i = 2; i * i < num; i++)
            {
                if (num % i != 0) continue;

                int temp = num / i;
                
                list.Add(i);
                list.Add(temp);

                sum += (i + temp);
            }

            if (num != sum + 1)
            {
                return null;
            }
            
            list.Sort();

            return list;
        }

        static int InputToInt() => int.Parse(Console.ReadLine());
    }
}