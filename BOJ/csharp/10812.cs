namespace BOJ
{
    class No_19583
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string[] inputs = input.ReadLine().Split();
            string s = inputs[0];
            string e = inputs[1];
            string q = inputs[2];

            int[] times = new int[3];

            List<string> checkin = new List<string>();
            List<string> checkout = new List<string>();

            for(int i = 0 ; i < inputs.Length ; i++)
            {
                int[] timeArray = Array.ConvertAll(inputs[i].Split(':'), int.Parse);

                int time = timeArray[0] * 60 + timeArray[1];

                times[i] = time;
            }

            while(true)
            {
                string temp = input.ReadLine();

                if(string.IsNullOrEmpty(temp))
                    break;

                inputs = temp.Split();


                int[] timeArray = Array.ConvertAll(inputs[0].Split(':'), int.Parse);

                int time = timeArray[0] * 60 + timeArray[1];

                string name = inputs[1];

                if(time <= times[0])
                {
                    checkin.Add(name);
                }
                else if(times[1] <= time && time <= times[2])
                {
                    checkout.Add(name);
                }
            }

            List<string> list = new List<string>();

            list = checkin.Intersect(checkout).ToList();

            output.Write(list.Count);
        }
    }
}