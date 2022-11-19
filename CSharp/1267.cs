using System;
using static System.Console;
using System.Text;

// 링크 : https://www.acmicpc.net/problem/1267

namespace BOJ
{
    internal class Program
    {
        static StringBuilder sb = new StringBuilder();
        static int n;
        static int sec;
        static int mCost;
        static int yCost;

        static int MRate(int _second)
        {
            int cost = 0;
            while (_second >= 0)
            {
                _second -= 60;
                cost += 15;
            }

            return cost;
        }

        static int YRate(int _second)
        {
            int cost = 0;
            while (_second >= 0)
            {
                _second -= 30;
                cost += 10;
            }

            return cost;
        }

        static void Main()
        {
            n = int.Parse(ReadLine());

            string[] inputs = ReadLine().Split(' ');

            foreach (var input in inputs)
            {
                sec = int.Parse(input);

                mCost += MRate(sec);
                yCost += YRate(sec);
            }


            if (mCost < yCost)
            {
                sb.Append("M ");
                sb.Append(mCost.ToString());
            }
            else if (mCost > yCost)
            {
                sb.Append("Y ");
                sb.Append(yCost.ToString());
            }
            else if (mCost == yCost)
            {
                sb.Append("Y M ");
                sb.Append(mCost.ToString());
            }

            WriteLine(sb.ToString());
        }
    }
}