using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

// 링크 : https://www.acmicpc.net/problem/10845

namespace BOJ
{
    class Program
    {
        static void Main(string[] args)
        {
            int myBack = 0;
            int testCase = int.Parse(Console.ReadLine());
            Queue<int> q = new Queue<int>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < testCase; i++)
            {
                string[] cmd = Console.ReadLine().Split(' ');

                switch (cmd[0])
                {
                    case "push":
                        myBack = int.Parse(cmd[1]);
                        q.Enqueue(myBack);
                        break;

                    case "pop":
                        sb.AppendLine(q.Count > 0 ? q.Dequeue().ToString() : "-1");
                        break;

                    case "size":
                        sb.Append(q.Count() + "\n");
                        break;
                    case "empty":
                        sb.AppendLine(q.Count == 0 ? "1" : "0");
                        break;
                    case "front":
                        sb.AppendLine(q.Count > 0 ? q.Peek().ToString() : "-1");
                        break;
                    case "back":
                        sb.AppendLine(q.Count > 0 ? myBack.ToString() : "-1");
                        break;
                }
            }

            Console.WriteLine(sb);
        }
    }
}