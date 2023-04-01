using System;
using System.Collections.Generic;

namespace _13_best_score
{
    class Program
    {
        public static string BestScore(Dictionary<string, int> myList)
        {
            int maxScore = 0;
            string student = "";
            foreach (KeyValuePair<string, int> item in myList)
            {
                if (maxScore < item.Value)
                {
                    maxScore = item.Value;
                    student = item.Key;
                }
            }
            return student;
        }
    }
}
