using System;
using System.Collections.Generic;

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/10828
 ***************************************************************************************/

namespace BaekJoon
{
    class Program
    {
        static void Main(string[] args)
        {

            int cnt = int.Parse(Console.ReadLine());
            Stack<int> st = new Stack<int>();

            while (cnt > 0)
            {
                string[] cmd = Console.ReadLine().Split(' ');
                StringBuilder sb = new StringBuilder();

                if (cmd[0] == "push")
                {
                    int temp = int.Parse(cmd[1]);
                    st.Push(temp);
                    cnt--;
                    continue;
                }
                else if (cmd[0] == "pop")
                {
                    if (st.Count == 0)
                    {
                        sb.Append("-1");
                    }
                    else
                    {
                        int temp = st.Pop();
                        sb.Append(temp);
                    }

                }
                else if (cmd[0] == "size")
                {
                    sb.Append(st.Count());
                }
                else if (cmd[0] == "empty")
                {
                    if (st.Count == 0)
                    {
                        sb.Append("1");
                    }
                    else
                    {
                        sb.Append("0");
                    }
                }
                else
                {
                    // cmd[0]=="top"
                    if (st.Count == 0)
                    {
                        sb.Append("-1");
                    }
                    else
                    {
                        int temp = st.Peek();
                        sb.Append(temp);
                    }
                }

                Console.WriteLine(sb);
                cnt--;
            }
        }
    }
}