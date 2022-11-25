using System;
using static System.Console;
using System.Text;

// 링크 : https://www.acmicpc.net/problem/2530

namespace BOJ
{
    internal class Program
    {
        struct Clock
        {
            public int hour;
            public int minute;
            public int second;

            public void AddSecond(int _time)
            {
                second += _time;

                SetLikeClock();
            }

            private void SetLikeClock()
            {
                if(second >= 60)
                {
                    minute += second / 60;
                    second %= 60;
                }

                if(minute >= 60)
                {
                    hour += minute / 60;
                    minute %= 60;
                }

                if(hour >= 24)
                {
                    hour %= 24;
                }
            }
        }

        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            Clock clock = new Clock();
            int ovenTime;

            string[] inputs = ReadLine().Split(' ');
            clock.hour = int.Parse(inputs[0]);
            clock.minute = int.Parse(inputs[1]);
            clock.second = int.Parse(inputs[2]);

            ovenTime = int.Parse(ReadLine());

            clock.AddSecond(ovenTime);

            sb.Append($"{clock.hour} {clock.minute} {clock.second}");

            Console.WriteLine(sb.ToString());
        }
    }
}