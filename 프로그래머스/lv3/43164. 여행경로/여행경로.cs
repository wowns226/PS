using System;
using System.Collections.Generic;

public class Solution
{
    Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

    public string[] solution(string[,] tickets)
    {
        SetDictionary(tickets);

        foreach(var key in dict.Keys)
            dict[key].Sort();

        List<string> route = new List<string>();
        route.Add("ICN");

        DFS(dict, "ICN", route, tickets.GetLength(0) + 1);


        string[] arr = route.ToArray();

        return route.ToArray();
    }

    private void SetDictionary(string[,] tickets)
    {
        for(int i = 0 ; i < tickets.GetLength(0) ; i++)
        {
            string from = tickets[i, 0];
            string to = tickets[i, 1];

            if(!dict.ContainsKey(from))
                dict[from] = new List<string>();

            dict[from].Add(to);
        }
    }

    private bool DFS(Dictionary<string, List<string>> graph, string current, List<string> route, int count)
    {
        if(route.Count == count)
        {
            return true;
        }

        if(!graph.ContainsKey(current) || graph[current].Count == 0)
        {
            return false;
        }

        List<string> nextCities = graph[current];

        for(int i = 0 ; i < nextCities.Count ; i++)
        {
            string nextCity = nextCities[i];
            nextCities.RemoveAt(i);
            route.Add(nextCity);

            if(DFS(graph, nextCity, route, count))
            {
                return true;
            }

            route.RemoveAt(route.Count - 1);
            nextCities.Insert(i, nextCity);
        }

        return false;
    }
}