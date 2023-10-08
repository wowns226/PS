using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static int N;
    static int[,] space;
    static int sharkSize = 2;
    static int sharkX, sharkY;
    static int eatenFish = 0;
    static int time = 0;
    static int[] dx = { -1, 0, 1, 0 };
    static int[] dy = { 0, -1, 0, 1 };

    static void Main()
    {
        N = int.Parse(Console.ReadLine());
        space = new int[N, N];

        for(int i = 0 ; i < N ; i++)
        {
            var row = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for(int j = 0 ; j < N ; j++)
            {
                space[i, j] = row[j];
                if(space[i, j] == 9)
                {
                    sharkX = i;
                    sharkY = j;
                    space[i, j] = 0;
                }
            }
        }

        while(true)
        {
            int result = FindNearestFish();
            if(result == 0)
                break;
            time += result;
        }

        Console.WriteLine(time);
    }

    static int FindNearestFish()
    {
        bool[,] visited = new bool[N, N];
        Queue<(int, int, int)> queue = new Queue<(int, int, int)>();
        List<(int, int, int)> possibleFish = new List<(int, int, int)>();

        queue.Enqueue((sharkX, sharkY, 0));
        visited[sharkX, sharkY] = true;

        while(queue.Count > 0)
        {
            var (x, y, dist) = queue.Dequeue();

            if(space[x, y] != 0 && space[x, y] < sharkSize)
                possibleFish.Add((x, y, dist));

            for(int i = 0 ; i < 4 ; i++)
            {
                int nx = x + dx[i];
                int ny = y + dy[i];

                if(nx >= 0 && nx < N && ny >= 0 && ny < N && !visited[nx, ny] && space[nx, ny] <= sharkSize)
                {
                    visited[nx, ny] = true;
                    queue.Enqueue((nx, ny, dist + 1));
                }
            }
        }

        if(possibleFish.Count == 0)
            return 0;

        possibleFish.Sort((a, b) =>
        {
            if(a.Item3 != b.Item3)
                return a.Item3.CompareTo(b.Item3);
            if(a.Item1 != b.Item1)
                return a.Item1.CompareTo(b.Item1);
            return a.Item2.CompareTo(b.Item2);
        });

        var (fishX, fishY, distToFish) = possibleFish[0];

        sharkX = fishX;
        sharkY = fishY;
        space[fishX, fishY] = 0;
        eatenFish++;

        if(eatenFish == sharkSize)
        {
            sharkSize++;
            eatenFish = 0;
        }

        return distToFish;
    }
}
