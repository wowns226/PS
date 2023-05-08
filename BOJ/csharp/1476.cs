namespace BOJ
{
    class No_1476
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
            int e = inputs[0];
            int s = inputs[1];
            int m = inputs[2];

            int year = 0;
            int et = 0;
            int st = 0;
            int mt = 0;
            while(true)
            {
                if(e == et && s == st && m == mt) break;

                year++;
                et++;
                st++;
                mt++;

                if(et > 15) et = 1;
                if(st > 28) st = 1;
                if(mt > 19) mt = 1;
            }

            output.Write(year);
        }
    }
}