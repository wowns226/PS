using System;
using static System.Console;
using System.Text;

// 링크 : https://www.acmicpc.net/problem/1032

namespace BOJ
{
    internal class Program
    {
        static StringBuilder sb = new StringBuilder();
        static int n;
        static string s;
        static char[] arr = new char[51];

        static void Main()
        {
            n = int.Parse(ReadLine());

            s = Console.ReadLine();
            for(int i = 0 ; i < s.Length ; i++)
            {
                arr[i] = s[i];
            }
            n--;

            while(n-- > 0)
            {
                string s = Console.ReadLine();

                for(int i = 0 ; i < s.Length ; i++)
                {
                    if(arr[i] != s[i])
                    {
                        arr[i] = '?';
                    }
                }
            }

            for(int i=0 ;i<s.Length ; i++)
            {
                sb.Append(arr[i]);
            }

            WriteLine(sb.ToString());
        }
    }
}