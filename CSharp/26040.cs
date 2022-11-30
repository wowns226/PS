using System;
using static System.Console;
using System.Text;

// 링크 : https://www.acmicpc.net/problem/26040

namespace BOJ
{
    internal class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            string s = ReadLine();
            string[] inputs = ReadLine().Split(' ');

            for (int i = 0; i < s.Length; i++)
            {
                bool isSame = false;
                for (int j = 0; j < inputs.Length; j++)
                {

                    char A = s[i];
                    char B = Convert.ToChar(inputs[j]);

                    if (A == B)
                    {
                        isSame = true;
                        break;
                    }
                }

                if (isSame)
                {
                    sb.Append(Char.ToLower(s[i]).ToString());
                }
                else
                {
                    sb.Append(s[i].ToString());
                }
            }

            WriteLine(sb.ToString());
        }
    }
}