using System;
using System.Text;

// https://www.acmicpc.net/problem/20053

namespace BOJ
{
    internal class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();            
            int testCase = int.Parse(Console.ReadLine());
            
            for(int i = 0 ; i < testCase ; i++)
            {
                int numCount = int.Parse(Console.ReadLine());
                string[] nums = Console.ReadLine().Split(' ');
                int MyMax = -123456789;
                int MyMin = 123456789;

                for(int j = 0 ; j < numCount ; j++)
                {
                    int num = int.Parse(nums[j]);

                    if(num > MyMax)
                    {
                        MyMax = num;
                    }

                    if(num < MyMin)
                    {
                        MyMin = num;
                    }
                }

                sb.Append(MyMin.ToString());
                sb.Append(' ');
                sb.AppendLine(MyMax.ToString());
            }

            Console.Write(sb);
        }
    }
}