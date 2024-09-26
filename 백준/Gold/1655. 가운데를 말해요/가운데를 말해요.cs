using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace BOJ
{
    class Program
    {
        static void Main()
        {
            var sb = new StringBuilder();
            using (var reader = new StreamReader(Console.OpenStandardInput()))
            {
                var numbers = new List<int>();
                var N = int.Parse(reader.ReadLine());
                var number = int.Parse(reader.ReadLine());
                numbers.Add(number);
                sb.Append($"{numbers[(numbers.Count - 1) / 2]}{Environment.NewLine}");

                number = int.Parse(reader.ReadLine());
                if (numbers[0] > number)
                    numbers.Insert(0, number);
                else
                    numbers.Add(number);

                sb.Append($"{numbers[(numbers.Count - 1) / 2]}{Environment.NewLine}");

                for (int i = 2; i < N; i++)
                {
                    number = int.Parse(reader.ReadLine());
                    int low = 0;
                    int high = numbers.Count - 1;
                    int InsertIndex = 0;
                    while (low <= high)
                    {
                        int mid = (low + high) / 2;
                        if (number < numbers[mid])
                        {
                            high = mid - 1;
                            InsertIndex = mid;
                        }
                        else
                        {
                            low = mid + 1;
                            InsertIndex = low;
                        }
                    }

                    if (numbers.Count - 1 < InsertIndex)
                        numbers.Add(number);
                    else
                        numbers.Insert(InsertIndex, number);

                    sb.Append($"{numbers[(numbers.Count - 1) / 2]}{Environment.NewLine}");
                }

                Console.Write(sb.ToString());
            }
        }
    }
}