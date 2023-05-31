namespace BOJ
{
    class No_2170
    {
        class Line
        {
            public int start;
            public int end;

            public Line(int start, int end)
            {
                this.start = start;
                this.end = end;
            }
        }

        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(input.ReadLine());
            List<Line> lines = new List<Line>();
            for(int i = 0 ; i < n ; i++)
            {
                int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
                lines.Add(new Line(inputs[0], inputs[1]));
            }

            var sorted = lines.OrderBy(x => x.start).ToList();

            int answer = 0;
            int right = int.MinValue;
            int left = int.MinValue;
            for(int i=0 ;i<n ;i++)
            {
                if(sorted[i].start <= right)
                    right = Math.Max(right, sorted[i].end);
                else
                {
                    answer += right - left;
                    left = sorted[i].start;
                    right = sorted[i].end;
                }
            }
            answer += right - left;

            output.Write(answer);
        }
    }
}
