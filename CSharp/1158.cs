using System;
using System.Collections.Generic;

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/1158
 ***************************************************************************************/

namespace BaekJoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int front;
            var input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            // n=7, k=3

            Queue<int> q = new Queue<int>();

            for (int i = 1; i <= n; i++)
            {
                q.Enqueue(i);
            }
            // q = (1,2,3,4,5,6,7)

            StringBuilder sb = new StringBuilder("<");
            while (q.Count > 0)
            {
                if (q.Count == 1)
                {
                    front = q.Dequeue();
                    sb.Append($"{front}");
                }
                else
                {
                    for (int i = 0; i < k - 1; i++)
                    {
                        front = q.Dequeue();
                        q.Enqueue(front);
                    }

                    front = q.Dequeue();
                    sb.Append($"{front}, ");
                }
            }
            sb.Append(">");

            Console.Write(sb);
        }
    }
}