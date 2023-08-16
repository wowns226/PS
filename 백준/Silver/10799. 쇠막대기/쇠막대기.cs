namespace BOJ
{
    class No_10799
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string s = input.ReadLine();

            int answer = 0;
            Stack<char> st = new Stack<char>();

            st.Push(s[0]);

            for(int i=1 ;i<s.Length; i++)
            {
                if(s[i] == '(')
                    st.Push(s[i]);
                else
                {
                    st.Pop();

                    if(s[i-1] == '(')
                        answer += st.Count;
                    else
                        answer++;
                    
                }
            }

            output.Write(answer);
        }
    }
}