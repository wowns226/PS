using System.Text;

namespace BOJ
{
    class No_1992
    {
        static char[,] arr;
        static StringBuilder sb = new StringBuilder();

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            arr = new char[n, n];

            for(int i=0 ;i<n ;i++)
            {
                string s = Console.ReadLine();
                for(int j=0 ;j<s.Length ;j++)
                {
                    arr[i, j] = s[j];
                }
            }

            DFS(0, 0, n);

            Console.WriteLine(sb);
        }

        static void DFS(int x, int y, int n)
        {
            for(int i = x ; i < x + n ; i++)
            {
                for(int j = y ; j < y + n ; j++)
                {
                    if(arr[i,j] != arr[x, y])
                    {
                        sb.Append("(");
                        DFS(x, y, n / 2);
                        DFS(x, y + n / 2, n / 2);
                        DFS(x + n / 2, y, n / 2);
                        DFS(x + n / 2, y + n / 2, n / 2);
                        sb.Append(")");
                        return;
                    }
                }
            }
            sb.Append(arr[x, y]);
        }
    }
}