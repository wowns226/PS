using System.Text;

namespace BOJ
{
    static class Input<T>
    {
        static public T Get() => ConvertTo(Console.ReadLine());
        static T ConvertTo(string s) => (T)Convert.ChangeType(s, typeof(T));
    }
    
    class No_10974
    {
        static StringBuilder sb = new StringBuilder();
        static bool[] used;
        static int[] num;
        static int input;
        
        static void Main()
        {
            input = Input<int>.Get();
            used = new bool[input + 1];
            num = new int[input + 1];

            Recur(0);

            Console.Write(sb);
        }

        static void Recur(int depth)
        {
            if (depth == input)
            {
                for (int i = 0; i < input; i++)
                {
                    sb.Append($"{num[i]} ");
                }

                sb.AppendLine();

                return;
            }

            for (int i = 0; i < input; i++)
            {
                if (used[i] != false) continue;
                
                used[i] = true;
                num[depth] = i + 1;
                Recur(depth + 1);
                used[i] = false;
            }
        }
    }
}