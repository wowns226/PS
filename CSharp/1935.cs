using System;

// 링크 : https://www.acmicpc.net/problem/1935

namespace BOJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] alp = new double[26];
            Stack<double> st = new Stack<double>();
            int alpNum = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            for (int i = 0; i < alpNum; i++)
            {
                alp[i] = float.Parse(Console.ReadLine());
            }

            foreach (char c in s)
            {
                if (c == '+' || c == '-' || c == '*' || c == '/')
                {
                    double b = st.Pop();
                    double a = st.Pop();

                    switch (c)
                    {
                        case '+':
                            st.Push(a + b);
                            break;
                        case '-':
                            st.Push(a - b);
                            break;
                        case '*':
                            st.Push(a * b);
                            break;
                        case '/':
                            st.Push(a / b);
                            break;
                    }
                }
                else
                {
                    st.Push(alp[(int)c - (int)'A']);
                }
            }

            Console.WriteLine(string.Format("{0:F2}", st.Pop()));
        }
    }
}