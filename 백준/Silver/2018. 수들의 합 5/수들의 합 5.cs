namespace BOJ
{
    static class Input<T>
    {
        static public T Get() => ConvertTo(Console.ReadLine());
        static T ConvertTo(string s) => (T)Convert.ChangeType(s, typeof(T));
    }
    
    class No_2018
    {
        static void Main()
        {
            var target = Input<int>.Get();

            int count = 0, sum = 0;
            for (int i = 1; sum <= target; i++)
            {
                sum += i;
                if ((target - sum) >= 0 && (target - sum) % i == 0) count++;
            }

            Console.WriteLine(count);
        }
    }
}