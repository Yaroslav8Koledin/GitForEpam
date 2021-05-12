using System;
using System.Collections.Generic;
using System.Linq;

namespace Epam.Task_3._1._2.TEXT_ANALYSIS
{
    public static class CheckTextOrLine
    {
        public static void CheckText(this string str)
        {
            Console.WriteLine("Start checking...");
            string[] str2 = str.Split(new char[] { '.', '!', '?', }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < str2.Length; i++)
            {
                Console.Write($"Sentence {i}: ");
                if (str2[i].CheckSentence())
                {
                    Console.WriteLine("correct");
                }
            }

            Console.WriteLine("Check passed...");
        }

        private static bool CheckSentence(this string str)
        {
            return GetDublicate(str) && CheckFistSymbol(str);
        }

        private static bool GetDublicate(string str)
        {
            bool flag = true;
            string[] strList = str.Split(new char[] { ' ', ',', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> wordFrequency = GetDictionaryOfPairs(strList);

            var maxCountOfFrequency = wordFrequency.Where(word => word.Value > 1);
            if (maxCountOfFrequency.Count() != 0)
            {
                flag = false;
                Console.Write("Uncorrect word:  ");
                foreach (var item in maxCountOfFrequency)
                {
                    Console.Write($"{item} ");
                }

                Console.WriteLine();
            }

            return flag;
        }

        private static bool CheckFistSymbol(string str)
        {
            int j = 0;
            bool flag = true;

            while (char.IsWhiteSpace(str[j]))
            {
                j++;
            }

            if (char.IsLower(str[j]))
            {
                Console.WriteLine("Replace the first letter with a capital letter");
                flag = false;
            }

            return flag;
        }

        private static Dictionary<string, int> GetDictionaryOfPairs(string[] strList)
        {
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>(StringComparer.CurrentCultureIgnoreCase);
            for (int i = 0; i < strList.Length; i++)
            {
                if (wordFrequency.ContainsKey(strList[i]))
                {
                    wordFrequency[strList[i]]++;
                }
                else
                {
                    wordFrequency.Add(strList[i], 1);
                }
            }

            return wordFrequency;
        }
    }
}