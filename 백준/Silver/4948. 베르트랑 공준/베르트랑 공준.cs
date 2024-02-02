using System.Text;

namespace BOJ
{
    static class Input<T>
    {
        static public T Get() => ConvertTo(Console.ReadLine());
        static T ConvertTo(string s) => (T)Convert.ChangeType(s, typeof(T));
    }
    
    class No_4948
    {
        static bool[] pNums = new bool[246_913];
        
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            Eratosthenes();
            while (true)
            {
                int n = Input<int>.Get();

                if (n == 0)
                {
                    Console.Write(sb);

                    return;
                }

                int answer = 0;
                for (int i = n + 1; i <= n * 2; i++)
                {
                    if (pNums[i] == false) answer++;
                }

                sb.AppendLine($"{answer}");
            }
        }

        static void Eratosthenes()
        {
            pNums[0] = true;
            pNums[1] = true;
            for (int i = 2; i < 246_913; i++)
            {
                if (pNums[i] == true) continue;
                for(int j = i * i; j < 246913; j += i)
                    if (j % i == 0)
                        pNums[j] = true;
            }
        }
    }
}