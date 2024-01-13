using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BOJ
{
    class No_20291
    {
        static void Main()
        {
            var fileCount = InputToInt();

            List<string> fileList = new List<string>();

            for (int i = 0; i < fileCount; i++)
            {
                fileList.Add(Input());
            }
            
            var extensionFiles = fileList
                .GroupBy(fileName => fileName.Split('.').Last(), StringComparer.OrdinalIgnoreCase)
                .OrderBy(group => group.Key)
                .Select(group => new { Extension = group.Key, Count = group.Count() });

            StringBuilder sb = new StringBuilder();

            foreach (var item in extensionFiles)
            {
                sb.AppendLine($"{item.Extension} {item.Count}");
            }

            Console.Write(sb);
        }

        static string Input() => Console.ReadLine();
        static int InputToInt() => int.Parse(Console.ReadLine());
    }
}