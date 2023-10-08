namespace BOJ
{
    class No_8979
    {
        class Country
        {
            public int PersonalNumber { get; } = 0;
            public int Gold { get; } = 0;
            public int Silver { get; } = 0;
            public int Bronze { get; } = 0;
            public int Rank { get; set; } = 0;

            public Country(int personalNumber, int gold, int silver, int bronze)
            {
                PersonalNumber = personalNumber;
                Gold = gold;
                Silver = silver;
                Bronze = bronze;
            }

            public bool IsSameOtherCountry(Country other)
            {
                if(Gold == other.Gold && Silver == other.Silver && Bronze == other.Bronze)
                    return true;

                return false;
            }
        }

        static int n, k;
        static List<Country> countryList = new List<Country>();

        public static void Main()
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            n = inputs[0];
            k = inputs[1];

            for(int i=0 ;i<n ;i++)
            {
                inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                Country newCountory = new Country(inputs[0], inputs[1], inputs[2], inputs[3]);
                countryList.Add(newCountory);
            }

            var sortedList = countryList.OrderByDescending(x => x.Gold).ThenByDescending(x => x.Silver).ThenByDescending(x => x.Bronze).ToList();

            int rank = 1;
            sortedList[0].Rank = rank;
            Country before = sortedList[0];
            for(int i=1 ;i<sortedList.Count ;i++)
            {
                rank++;

                if(sortedList[i].IsSameOtherCountry(before))
                {
                    sortedList[i].Rank = before.Rank;
                }
                else
                {
                    sortedList[i].Rank = rank;
                }

                before = sortedList[i];
            }

            for(int i=0 ;i<sortedList.Count ;i++)
            {
                if(sortedList[i].PersonalNumber == k)
                {
                    Console.WriteLine(sortedList[i].Rank);
                    return;
                }
            }
        }
    }
}