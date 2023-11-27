using System.Text;

namespace BOJ_2527
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            
            for (int i = 0; i < 4; i++)
            {
                int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                int xl = Max(inputs[0], inputs[4]);
                int xr = Min(inputs[2], inputs[6]);
                int yb = Max(inputs[1], inputs[5]);
                int yt = Min(inputs[3], inputs[7]);

                int xgap = xr - xl;
                int ygap = yt - yb;

                if (xgap > 0 && ygap > 0) Console.WriteLine('a');
                else if (xgap < 0 || ygap < 0) Console.WriteLine('d');
                else if (xgap == 0 && ygap == 0) Console.WriteLine('c');
                else Console.WriteLine('b');
            }

            Console.WriteLine(sb);
        }

        static int Max(int x, int y) => Math.Max(x, y);
        static int Min(int x, int y) => Math.Min(x, y);
    }
}
