namespace BOJ
{
    class No_2493
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(input.ReadLine());
            int num, height;
            Stack<(int, int)> st = new Stack<(int, int)>();

            int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
            for(int i=0 ;i<n ;i++)
            {
                height = inputs[i];

                while(st.Count > 0)
                {
                    if(height < st.Peek().Item2)
                    {
                        output.Write($"{st.Peek().Item1} ");
                        break;
                    }

                    st.Pop();
                }

                if(st.Count == 0)
                    output.Write("0 ");

                st.Push((i + 1, height));
            }
        }
    }
}
