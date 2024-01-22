using System.Text;

namespace BOJ
{
    static class Input<T>
    {
        public static T Get() => ConvertTo(Console.ReadLine());
        public static T[] GetArray() => Array.ConvertAll(Console.ReadLine().Split(), ConvertTo);
        private static T ConvertTo(string s) => (T)Convert.ChangeType(s, typeof(T));
    }
    
    class No_28278
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            Stack<int> stack = new Stack<int>();
            int N = Input<int>.Get();
            for (int i = 0; i < N; i++)
            {
                var inputs = Input<int>.GetArray();
                switch (inputs[0])
                {
                    case 1:
                        stack.Push(inputs[1]);
                        break;
                    case 2:
                        if (stack.Count > 0)
                        {
                            sb.AppendLine($"{stack.Peek()}");
                            stack.Pop();
                        }
                        else
                        {
                            sb.AppendLine("-1");
                        }
                        break;
                    case 3:
                        sb.AppendLine($"{stack.Count}");
                        break;
                    case 4:
                        sb.AppendLine(stack.Count == 0 ? "1" : "0");
                        break;
                    case 5:
                        sb.AppendLine(stack.Count > 0 ? $"{stack.Peek()}" : "-1");
                        break;
                }
            }

            Console.Write(sb);
        }
    }
}