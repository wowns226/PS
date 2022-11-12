using System;
using System.Text;

// 링크 : https://www.acmicpc.net/problem/4949

namespace BOJ
{
    internal class Program
    {
        static void Main()
        {
            while(true)
            {
                string s = Console.ReadLine();
                StringBuilder sb = new StringBuilder();
                Stack<char> st = new Stack<char>();

                if(s.Equals("."))
                {
                    break;
                }

                foreach(char c in s)
                {
                    if(c.Equals('(') || c.Equals('[')){
                        st.Push(c);
                    }

                    else if (c.Equals(')'))
                    {
                        if(st.Count == 0)
                        {
                            st.Push(c);
                            break;
                        }
                        if(st.Peek() == '(')
                        {
                            st.Pop();
                        }
                        else 
                        {
                            break;
                        }
                    }
                    else if(c.Equals(']'))
                    {
                        if(st.Count == 0)
                        {
                            st.Push(c);
                            break;
                        }
                        if(st.Peek() == '[')
                        {
                            st.Pop();
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                if(st.Count == 0)
                {
                    sb.Append("yes");
                }
                else
                {
                    sb.Append("no");
                }

                Console.WriteLine(sb);
            }
            
        }
    }
}