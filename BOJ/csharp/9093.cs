using System;

namespace BOJ
{
    class No_9093
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int testCase = int.Parse(input.ReadLine());

            while(testCase-->0)
            {
                string[] inputs = input.ReadLine().Split();

                Queue<string> q = new Queue<string>();
                Stack<char> st = new Stack<char>();

                for(int i=0 ;i<inputs.Length; i++)
                    q.Enqueue(inputs[i]);

                while(q.Count > 0)
                {
                    var cur = q.Dequeue();
                    var count = cur.Length;

                    for(int i = 0 ; i < count ; i++)
                        st.Push(cur[i]);

                    for(int i = 0 ; i < count ; i++)
                        output.Write(st.Pop());

                    output.Write(' ');
                }

                output.WriteLine();
            }
        }
    }
}