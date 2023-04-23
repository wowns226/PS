using System;
using static System.Console;
using System.Text;

// 링크 : https://www.acmicpc.net/problem/1526

namespace BOJ
{
    internal class Program
    {
        static bool IsFourOrSeven(int _num)
        {
            while(_num != 0)
            {
                if(_num % 10 == 4 || _num % 10 == 7)
                {
                    _num /= 10;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(ReadLine());

            for(int i = n ; i >= 1 ; i--)
            {
                if(IsFourOrSeven(i))
                {
                    sb.Append(i);
                    break;
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}