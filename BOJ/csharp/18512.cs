namespace BOJ
{
    class No_18512
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);

            int x = inputs[0];
            int y = inputs[1];
            int p1 = inputs[2];
            int p2 = inputs[3];

            int answer = -1;
            int cnt = 0;
            int px = p1, py = p2;
            while(cnt < 1000)
            {
                if(px == py)
                {
                    answer = px;
                    break;
                }

                if(px < py)
                    px += x;
                else
                    py += y;

                cnt++;
            }

            output.WriteLine(answer);
        }
    }
}

