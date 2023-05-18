namespace BOJ
{
    class No_25206
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            Dictionary<string, float> scores = new Dictionary<string, float>()
            {
                { "A+", 4.5f },
                { "A0", 4.0f },
                { "B+", 3.5f },
                { "B0", 3.0f },
                { "C+", 2.5f },
                { "C0", 2.0f },
                { "D+", 1.5f },
                { "D0", 1.0f },
                { "F", 0.0f },
            };

            float count = 0;
            float answer = 0f;
            while(true)
            {
                string s = input.ReadLine();
                string[] inputs;

                if(string.IsNullOrEmpty(s))
                    break;
                else
                    inputs = s.Split();

                if(inputs[2] == "P")
                    continue;

                answer += float.Parse(inputs[1]) * scores[inputs[2]];
                count += float.Parse(inputs[1]);
            }

            string avg = string.Format("{0:F6}", answer / count);

            output.Write(avg);
        }
    }
}
