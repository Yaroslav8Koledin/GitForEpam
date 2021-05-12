using System;

namespace Epam.Task_3._3._2.SUPER_STRING
{
    public static class CheckLanguage
    {
        private static Predicate<char> pred;

        public static bool IsEnglish(this char elem)
        {
            if (elem <= 'z' && elem >= 'A')
                return true;

            return false;
        }

        public static bool IsRussian(this char elem)
        {
            if (elem <= 'я' && elem >= 'А')
                return true;

            return false;
        }

        public static bool IsNumber(this char elem)
        {
            if (elem <= '9' && elem >= '1')
                return true;

            return false;
        }

        public static string GetLanguage(this char ch)
        {
            if(ch.IsEnglish())
            {
                return "English";
            }

            if(ch.IsNumber())
            {
                return "Number";
            }

            if(ch.IsRussian())
            {
                return "Russian";
            }

            return "Mixed";
        }

        public static void Compr(string arr, ref string language)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (!(pred(arr[i])))
                {
                    language = "Mixed";
                }
            }
        }

        public static string GetLanguage(this string str)
        {
            string language = str[0].GetLanguage();

            switch(language)
            {
                case "Russian":
                    {
                        pred = IsRussian;
                        Compr(str, ref language);
                        break;
                    }
                case "English":
                    {
                        pred = IsEnglish;
                        Compr(str, ref language);
                        break;
                    }
                case "Number":
                    {
                        pred = IsNumber;
                        Compr(str, ref language);
                        break;
                    }
                default:
                    break;
            }

            return language;
        }
    }
}
