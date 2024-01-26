namespace BOJ
{
    static class Input<T>
    {
        static public T[] GetArray() => Array.ConvertAll(Console.ReadLine().Split(), ConvertTo);
        static T ConvertTo(string s) => (T)Convert.ChangeType(s, typeof(T));
    }
    
    class No_16434
    {
        static void Main()
        {
            var inputs = Input<int>.GetArray();
            // 방의 개수 N
            int N = inputs[0];
            // 초기 공격력 H
            long H = inputs[1];
            long curHp = 0, maxHp = 0;

            for (int i = 0; i < N; i++)
            {
                inputs = Input<int>.GetArray();
                int t = inputs[0];
                int a = inputs[1];
                int h = inputs[2];

                if (t == 1)
                {
                    curHp += a * ((h / H) - (h % H != 0 ? 0 : 1));
                    maxHp = Math.Max(maxHp, curHp);
                }
                else
                {
                    H += a;
                    curHp = Math.Max(curHp - h, 0);
                }
            }

            maxHp++;

            Console.WriteLine(maxHp);
        }
    }
}