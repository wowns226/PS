namespace BOJ_1064
{
    class Program
    {
        static void Main()
        {
            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            List<double> list = new List<double>();
            
            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            
            if ((inputs[1] - inputs[3]) * (inputs[2] - inputs[4]) == (inputs[3] - inputs[5]) * (inputs[0] - inputs[2]))
            {
                sw.WriteLine("-1.0");

                return;
            }

            int dx1 = inputs[0] - inputs[2];
            int dy1 = inputs[1] - inputs[3];
            double line1 = Math.Abs(Math.Sqrt(dx1 * dx1 + dy1 * dy1));
            
            int dx2 = inputs[2] - inputs[4];
            int dy2 = inputs[3] - inputs[5];
            double line2 = Math.Abs(Math.Sqrt(dx2 * dx2 + dy2 * dy2));

            int dx3 = inputs[0] - inputs[4];
            int dy3 = inputs[1] - inputs[5];
            double line3 = Math.Abs(Math.Sqrt(dx3 * dx3 + dy3 * dy3));

            list.Add(line1 * 2 + line2 * 2);
            list.Add(line2 * 2 + line3 * 2);
            list.Add(line1 * 2 + line3 * 2);
            
            sw.Write(list.Max() - list.Min());
        }
    }
}
