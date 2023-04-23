using System;
using System.Text;

// 링크 : https://www.acmicpc.net/problem/2753

namespace BOJ
{
    internal class Program
    {
        static bool LeapYear(int _year )
        {
            if(_year % 4 == 0 && (_year % 100 !=0 || _year% 400 == 0))
            {
                return true;
            }
            return false;
        }

        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int year = int.Parse(Console.ReadLine());

            if(LeapYear(year))
            {
                sb.Append("1");
            }
            else
            {
                sb.Append("0");
            }

            Console.WriteLine(sb);
        }
    }
}