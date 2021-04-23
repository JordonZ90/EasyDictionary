using System;
using System.Collections.Generic;

namespace TheDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            TheDictionary();
        }
        public static void TheDictionary()
        {
            Dictionary<int, string> bookList = new Dictionary<int, string>()
            {
                {019874946, "Green Eggs and Ham" },
                {017985621, "The Stand" },
                {000879545, "Hunger Games" }
            };
            Dictionary<int, string> forLoopFriendlyDict = new Dictionary<int, string>()
            {
                {0, "Wolverine" },
                {1, "LoTR" },
                {2, "Star Wars" }
            };
            bookList.Add(030779445, "Harry Potter");
            forLoopFriendlyDict.Add(3, "Spiderman");

            string favoriteBook = bookList[017985621];

            Console.WriteLine($"My favorite book is, {favoriteBook}");
            Console.WriteLine($"There are {bookList.Count} books in the dictionary");

            for (int index = 0; index < forLoopFriendlyDict.Count; index++)
            {
                Console.WriteLine($"{index}: {forLoopFriendlyDict[index]}");
            }

            foreach (KeyValuePair<int, string> entry in bookList)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }

        }
    }
}
