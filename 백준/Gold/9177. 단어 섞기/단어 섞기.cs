using System;
using System.Text;

namespace BOJ
{
    static class Input<T>
    {
        public static T Get() => ConvertTo(Console.ReadLine());
        public static T[] GetArray() => Array.ConvertAll(Console.ReadLine().Split(), ConvertTo);
        private static T ConvertTo(string s) => (T)Convert.ChangeType(s, typeof(T));
    }
    
    class No_9177
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int testCase = Input<int>.Get();
            for (int i = 1; i <= testCase; i++)
            {
                var inputs = Input<string>.GetArray();
                string s1 = inputs[0];
                string s2 = inputs[1];
                string target = inputs[2];
                
                int s1Len = s1.Length;
                int s2Len = s2.Length;

                bool[,] dp = new bool[s1Len + 1, s2Len + 1];
                dp[0, 0] = true;
                for (int a = 1; a <= s1Len; a++)
                {
                    dp[a, 0] = (s1[a - 1] == target[a - 1]) && dp[a - 1, 0];
                }

                for (int a = 1; a <= s2Len; a++)
                {
                    dp[0, a] = (s2[a - 1] == target[a - 1]) && dp[0, a - 1];
                }

                for (int a = 1; a <= s1Len; a++)
                {
                    for (int b = 1; b <= s2Len; b++)
                    {
                        char curA = s1[a - 1], curB = s2[b - 1], curC = target[a + b - 1];
                        if (curA != curC && curB != curC)
                        {
                            dp[a, b] = false;
                        }
                        else if (curA == curC && curB != curC)
                        {
                            dp[a, b] = dp[a - 1, b];
                        }
                        else if (curA != curC && curB == curC)
                        {
                            dp[a, b] = dp[a, b - 1];
                        }
                        else
                        {
                            dp[a, b] = dp[a - 1, b] || dp[a, b - 1];
                        }
                    }
                }

                sb.AppendLine($"Data set {i}: {(dp[s1Len, s2Len] ? "yes" : "no")}");
            }

            Console.Write(sb);
        }
    }
}