using System;
using System.Text;
using System.Collections.Generic;

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/9012
 ***************************************************************************************/

namespace BaekJoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCase; i++)
            {
                string s = Console.ReadLine();
                Stack<char> stack = new Stack<char>();
                StringBuilder sb = new StringBuilder();
                bool isVPS = true;

                foreach (var sc in s)
                {
                    if (sc == '(')
                    {
                        stack.Push('(');
                    }
                    else
                    {
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }
                        else
                        {
                            isVPS = false;
                        }
                    }
                }

                if (isVPS)
                {
                    if (stack.Count > 0)
                    {
                        sb.Append("NO");
                    }
                    else
                    {
                        sb.Append("YES");
                    }
                }
                else
                {
                    sb.Append("NO");
                }


                Console.WriteLine(sb.ToString());
            }
        }
    }
}