using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

// 링크 : https://www.acmicpc.net/problem/18258

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
                        if (q.Count == 0)
                        {
                            sb.AppendLine("-1");
                        }
                        else
                        {
                            sb.Append(q.Dequeue() + "\n");
                        }
                        break;

                    case "size":
                        sb.Append(q.Count() + "\n");
                        break;
                    case "empty":
                        if (q.Count() == 0)
                        {
                            sb.AppendLine("1");
                        }
                        else
                        {
                            sb.AppendLine("0");
                        }
                        break;
                    case "front":
                        if (q.Count == 0)
                        {
                            sb.AppendLine("-1");
                        }
                        else
                        {
                            sb.Append(q.Peek() + "\n");
                        }
                        break;
                    case "back":
                        if (q.Count == 0)
                        {
                            sb.AppendLine("-1");
                        }
                        else
                        {
                            sb.Append(myBack + "\n");
                        }
                        break;
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}