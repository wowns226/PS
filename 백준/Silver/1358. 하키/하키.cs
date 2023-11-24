namespace BOJ_1358
{
    class Program
    {
        static void Main()
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int w = inputs[0];
            int h = inputs[1];
            int x = inputs[2];
            int y = inputs[3];
            int p = inputs[4];

            int count = 0;
            for (int i = 0; i < p; i++)
            {
                inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (IsInLink(w, h, x, y, inputs[0], inputs[1]))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        static bool IsInLink(int w, int h, int x, int y, int px, int py)
        {
            int r = h / 2;

            if (px < x - r) return false;
            if (px > x + w + r) return false;
            if (py < y) return false;
            if (py > y + h) return false;
            
            // 왼쪽 호 체크
            if (px < x)
            {
                int cy = y + h / 2;
            
                int dx = px - x;
                int dy = py - cy;
            
                return dx * dx + dy * dy <= r * r;
            }
            // 오른쪽 호 체크
            if (px > x+w)
            {
                int cx = x + w;
                int cy = y + h / 2;
                
                int dx = px - cx;
                int dy = py - cy;
            
                return dx * dx + dy * dy <= r * r;
            }

            return true;
        }
    }
}
