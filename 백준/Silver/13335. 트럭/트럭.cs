namespace BOJ
{
    class No_13335
    {
        static void Main()
        {
            var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = input[0];
            int w = input[1];
            int l = input[2];

            int[] a = new int[n];
            input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for(int i = 0 ; i < n ; i++)
                a[i] = input[i];
            

            Queue<int> q = new Queue<int>();
            int ans = 0;
            int sum = 0;

            for(int i = 0 ; i < n ; i++)
            {
                while(true)
                {
                    if(q.Count == w)
                        sum -= q.Dequeue();

                    if(sum + a[i] <= l)
                        break;
                    
                    q.Enqueue(0);
                    ans++;
                }

                q.Enqueue(a[i]);
                sum += a[i];
                ans++;
            }

            ans += w;
            Console.WriteLine(ans);
        }
    }
}


