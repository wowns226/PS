using System.Text;

namespace BOJ
{
    class No_1918
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            string s = Console.ReadLine();

            Stack<char> st = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] >= 'A' && s[i] <= 'Z')
                {
                    sb.Append(s[i]);
                }
                else
                {
                    if (s[i] == '(')
                    {
                        st.Push(s[i]);
                    }
                    else if (s[i] == ')')
                    {
                        while (st.Count > 0 && st.Peek() != '(')
                        {
                            sb.Append(st.Pop());
                        }

                        st.Pop();
                    }
                    else if(s[i] == '*' || s[i] == '/')
                    {
                        while (st.Count > 0 && (st.Peek() == '*' || st.Peek() == '/'))
                        {
                            sb.Append(st.Pop());
                        }
                        
                        st.Push(s[i]);
                    }
                    else
                    {
                        while (st.Count > 0 && st.Peek() != '(')
                        {
                            sb.Append(st.Pop());
                        }
                        
                        st.Push(s[i]);
                    }
                }
            }

            while (st.Count > 0)
            {
                sb.Append(st.Pop());
            }

            Console.WriteLine(sb);
        }
    }
}