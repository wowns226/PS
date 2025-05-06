using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class No_11000
{
    class ClassData
    {
        public int Start { get; set; }
        public int End { get; set; }
        public ClassData(int start, int end)
        {
            Start = start; End = end;
        }
    }

    public static void Main()
    {
        using var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        List<ClassData> classes = new List<ClassData>();

        int n = int.Parse(sr.ReadLine());

        while (n-- > 0)
        {
            int[] inputs = sr.ReadLine().Split().Select(int.Parse).ToArray();

            classes.Add(new ClassData(inputs[0], inputs[1]));            
        }

        classes = classes.OrderBy(c => c.Start).ThenBy(c => c.End).ToList();

        var pq = new PriorityQueue<int, int>();
        pq.Enqueue(classes[0].End, classes[0].End);

        for (int i = 1; i < classes.Count; i++)
        {
            if (pq.Peek() <= classes[i].Start)
            {
                pq.Dequeue();
            }

            pq.Enqueue(classes[i].End, classes[i].End);
        }

        sw.WriteLine(pq.Count);
    }
}