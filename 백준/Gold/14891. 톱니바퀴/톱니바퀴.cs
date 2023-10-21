using System;
using System.Collections.Generic;

class Program
{
    const int MAX_GEAR_NUM = 4;
    const int MAX_GEAR_PARTS_NUM = 8;

    class Gear
    {
        //public string Name;
        private int[] parts = new int[MAX_GEAR_PARTS_NUM];
        private int center = 0;
        private int score = 0;

        public Gear(string s, int score)
        {
            for(int i = 0 ; i < s.Length ; i++)
            {
                this.parts[i] = int.Parse(s[i].ToString());
            }

            this.score = score;
        }

        public int GetScore()
        {
            return parts[center] == 1 ? score : 0;
        }

        public int GetValue(int index)
        {
            return parts[index];
        }

        public int GetRightIndex()
        {
            int ret = center;

            ret += 2;

            return CheckIndex(ret);
        }

        public int GetLeftIndex()
        {
            int ret = center;

            ret -= 2;

            return CheckIndex(ret);
        }

        public void Rotation(int num)
        {
            if(num == 1) Right();
            else Left();
        }

        private void Right()
        {
            center--;

            center = CheckIndex(center);
        }

        private void Left()
        {
            center++;

            center = CheckIndex(center);
        }

        private int CheckIndex(int index)
        {
            int min = 0;
            int max = parts.Length;

            if(index < min)
                index += max;
            else if(index >= max)
                index -= max;

            return index;
        }
    }

    static void Main()
    {
        List<Gear> gears = new List<Gear>();

        int score = 1;
        for(int i=0 ;i<MAX_GEAR_NUM ;i++)
        {
            Gear newGear = new Gear(Console.ReadLine(), score);
            //newGear.Name = $"{i}번째 기어";
            gears.Add(newGear);
            score <<= 1;
        }

        int k = int.Parse(Console.ReadLine());

        int[] inputs;
        Queue<(Gear, int)> q = new Queue<(Gear, int)>();
        for(int i=0 ;i<k ;i++)
        {
            inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int gearIndex = inputs[0] - 1;
            int rotation = inputs[1];

            q.Clear();

            var rot = rotation;
            for(int index =gearIndex ;index>0 ;index--)
            {
                Gear centerGear = gears[index];
                Gear leftGear = gears[index - 1];

                int centerToLeftIndex = centerGear.GetLeftIndex();
                int leftToRightIndex = leftGear.GetRightIndex();

                int center = centerGear.GetValue(centerToLeftIndex);
                int left = leftGear.GetValue(leftToRightIndex);
                //Console.WriteLine($"{centerGear.Name}:{centerToLeftIndex} {leftGear.Name}:{leftToRightIndex} 비교");
                if(center != left)
                {
                    rot = -rot;
                    q.Enqueue((leftGear, rot));
                }
                else break;
            }

            rot = rotation;
            for(int index=gearIndex ;index<MAX_GEAR_NUM-1 ;index++)
            {
                Gear centerGear = gears[index];
                Gear rightGear = gears[index + 1];

                int centerToRightIndex = centerGear.GetRightIndex();
                int rightToLeftIndex = rightGear.GetLeftIndex();

                int center = centerGear.GetValue(centerToRightIndex);
                int right = rightGear.GetValue(rightToLeftIndex);
                //Console.WriteLine($"{centerGear.Name}:{centerToRightIndex} {rightGear.Name}:{rightToLeftIndex} 비교");
                if(center != right)
                {
                    rot = -rot;
                    q.Enqueue((rightGear, rot));
                }
                else break;
            }

            while(q.Count >0)
            {
                var cur = q.Dequeue();
                cur.Item1.Rotation(cur.Item2);
                //string s1 = cur.Item2 == 1 ? "오른쪽" : "왼쪽";
                //Console.WriteLine($"{cur.Item1.Name} {s1} 회전");
            }

            gears[gearIndex].Rotation(rotation);
            //string s = rotation == 1 ? "오른쪽" : "왼쪽";
            //Console.WriteLine($"{gears[gearIndex].Name} {s} 회전");
        }

        int answer = 0;
        foreach(var gear in gears)
        {
            answer += gear.GetScore();
        }

        Console.WriteLine(answer);
    }
}
