using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

// 링크 : https://www.acmicpc.net/problem/3986

namespace BOJ
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> st = new Stack<char>();
            int answer = 0;
            int testCase = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCase; i++)
            {
                string s = Console.ReadLine();

                st.Push(s[0]);

                for (int t = 1; t < s.Length; t++)
                {
                    if (st.Peek() == s[t])
                    {
                        st.Pop();
                    }
                    else
                    {
                        st.Push(s[t]);
                    }
                }

                if (st.Count == 0)
                {
                    answer++;
                }
            }

            Console.WriteLine($"{answer}");
        }
    }
}