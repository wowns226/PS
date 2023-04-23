using System;
using static System.Console;
using System.Text;

// 링크 : https://www.acmicpc.net/problem/2292

namespace BOJ
{
    internal class Program
    {
        static int GetMinRoomCount(int _num)
        {
            int checkCount = 0;
            int checkNum = 1;

            while (true)
            {
                checkNum += 6 * checkCount;

                if (_num <= checkNum)
                {
                    return checkCount + 1;
                }

                checkCount++;
            }
        }


        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(ReadLine());

            sb.Append(GetMinRoomCount(n).ToString());

            Console.WriteLine(sb.ToString());
        }
    }
}