using System;
using System.Collections.Generic;

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/2164
 ***************************************************************************************/

namespace BaekJoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();

            int testCase = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= testCase; i++)
            {
                q.Enqueue(i);
            }

            while (q.Count() > 1)
            {
                q.Dequeue();

                q.Enqueue(q.Dequeue());
            }

            Console.WriteLine(q.Dequeue());
        }
    }
}