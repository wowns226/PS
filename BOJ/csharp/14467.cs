using System;
using System.Text;

// 링크 : https://www.acmicpc.net/problem/14467

namespace BOJ
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = new int[11];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = -1;
            }

            int cowCase = int.Parse(Console.ReadLine());
            int cnt = 0;
            for (int i = 0; i < cowCase; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                int cowNum = int.Parse(input[0]);
                int cowLocation = int.Parse(input[1]);

                if (arr[cowNum - 1] == -1)
                {
                    arr[cowNum - 1] = cowLocation;
                }
                else
                {
                    if (arr[cowNum - 1] == cowLocation)
                    {
                        continue;
                    }
                    else
                    {
                        arr[cowNum - 1] = cowLocation;
                        cnt++;
                    }
                }
            }

            Console.WriteLine(cnt);
        }
    }
}