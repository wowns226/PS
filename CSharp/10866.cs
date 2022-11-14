using System;
using System.Text;

// 링크 : https://www.acmicpc.net/problem/10866

namespace BOJ
{
    internal class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            LinkedList<int> list = new LinkedList<int>();

            int cmdCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < cmdCount; i++)
            {
                string[] cmd = Console.ReadLine().Split(' ');

                switch (cmd[0])
                {
                    case "push_front":
                        int num = int.Parse(cmd[1]);
                        list.AddFirst(num);
                        break;

                    case "push_back":
                        num = int.Parse(cmd[1]);
                        list.AddLast(num);
                        break;

                    case "pop_front":
                        if (list.Count != 0)
                        {
                            num = list.First();
                            sb.AppendLine(num.ToString());
                            list.RemoveFirst();
                        }
                        else
                        {
                            sb.AppendLine("-1");
                        }
                        break;

                    case "pop_back":
                        if (list.Count != 0)
                        {
                            num = list.Last();
                            sb.AppendLine(num.ToString());
                            list.RemoveLast();
                        }
                        else
                        {
                            sb.AppendLine("-1");
                        }
                        break;

                    case "size":
                        sb.AppendLine(list.Count.ToString());
                        break;

                    case "empty":
                        if (list.Count == 0)
                        {
                            sb.AppendLine("1");
                        }
                        else
                        {
                            sb.AppendLine("0");
                        }
                        break;

                    case "front":
                        if (list.Count != 0)
                        {
                            num = list.First();
                            sb.AppendLine(num.ToString());
                        }
                        else
                        {
                            sb.AppendLine("-1");
                        }
                        break;

                    case "back":
                        if (list.Count != 0)
                        {
                            num = list.Last();
                            sb.AppendLine(num.ToString());
                        }
                        else
                        {
                            sb.AppendLine("-1");
                        }
                        break;
                }
            }

            Console.Write(sb);
        }
    }
}