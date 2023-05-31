namespace BOJ
{
    class No_17298
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(input.ReadLine());
            int num;
            Stack<int> st = new Stack<int>();
            Stack<int> answer = new Stack<int>();

            int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
            for(int i=n-1 ;i>=0 ;i--)
            {
                num = inputs[i];

                while(st.Count > 0)
                {
                    if(num < st.Peek())
                    {
                        answer.Push(st.Peek());
                        break;
                    }

                    st.Pop();
                }

                if(st.Count == 0)
                {
                    answer.Push(-1);
                }

                st.Push(num);
            }

            while(answer.Count > 0)
            {
                output.Write($"{answer.Pop()} ");
            }
        }
    }
}
