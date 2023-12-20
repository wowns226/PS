using System.Text;

namespace BOJ
{
    class No_1063
    {
        const int BOARD_MAX = 8;
        
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            Dictionary<string, (int, int)> dict = new Dictionary<string, (int, int)>();
            dict.Add("R", (1, 0));
            dict.Add("L", (-1, 0));
            dict.Add("B", (0, -1));
            dict.Add("T", (0, 1));
            dict.Add("RT", (1, 1));
            dict.Add("LT", (-1, 1));
            dict.Add("RB", (1, -1));
            dict.Add("LB", (-1, -1));
            
            string[] inputs = Console.ReadLine().Split();
            int kingX = inputs[0][0] - 'A';
            int kingY = int.Parse(inputs[0][1].ToString())-1;

            int stoneX = inputs[1][0] - 'A';
            int stoneY = int.Parse(inputs[1][1].ToString())-1;
           
            int movingCount = int.Parse(inputs[2]);

            for (int i = 0; i < movingCount; i++)
            {
                string command = Console.ReadLine();

                (int dx, int dy) = dict[command];

                int nx = kingX + dx;
                int ny = kingY + dy;
                
                if(nx<0 || ny<0 || nx>=BOARD_MAX || ny>=BOARD_MAX) continue;

                if (nx == stoneX && ny == stoneY)
                {
                    int nnx = stoneX + dx;
                    int nny = stoneY + dy;
                    
                    if(nnx<0 || nny<0 || nnx>=BOARD_MAX || nny>=BOARD_MAX) continue;
                    
                    stoneX = nnx;
                    stoneY = nny;
                }

                kingX = nx;
                kingY = ny;
            }

            sb.AppendLine($"{(char)(kingX + 'A')}{kingY + 1}");
            sb.AppendLine($"{(char)(stoneX + 'A')}{stoneY + 1}");

            Console.Write(sb);
        }
    }   
}