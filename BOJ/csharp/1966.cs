using System;
using System.Text;

// 링크 : https://www.acmicpc.net/problem/1966

namespace BOJ
{
    internal class Program
    {
        static void Main()
        {
            int testCase = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            while (testCase-- > 0)
            {
                int answer = 0;
                string[] input = Console.ReadLine().Split(' ');

                int n = int.Parse(input[0]);
                int m = int.Parse(input[1]);

                Queue<int> q = new Queue<int>(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));

                while (q.Count != 0)
                {
                    if (q.Peek() == q.Max())
                    {
                        answer++;
                        if (m == 0)
                        {
                            sb.AppendLine(answer.ToString());
                            break;
                        }

                        q.Dequeue();
                        m--;
                    }
                    else
                    {
                        if (m == 0)
                        {
                            m = q.Count;
                        }
                        q.Enqueue(q.Dequeue());
                        m--;
                    }
                }
            }

            Console.WriteLine(sb);
        }
    }
}