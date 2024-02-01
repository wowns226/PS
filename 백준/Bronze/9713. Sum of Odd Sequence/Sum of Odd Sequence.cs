using System.Text;

namespace BOJ
{
    static class Input<T>
    {
        static public T Get() => ConvertTo(Console.ReadLine());
        static T ConvertTo(string s) => (T)Convert.ChangeType(s, typeof(T));
    }
    
    class No_9713
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int N = Input<int>.Get();
            while (N-- > 0)
            {
                int number = Input<int>.Get();
                int answer = 0;
                for (int i = 1; i <= number; i += 2)
                {
                    answer += i;
                }

                sb.AppendLine($"{answer}");
            }

            Console.Write(sb);
        }
    }
}