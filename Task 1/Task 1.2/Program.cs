using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1_2
{
    class Program
    {
        public static string PUNCTUATION = "\"'(){}[]<>!:;.,-_+=/|\\*`~^#%&@№ \t\n";
        static void Main(string[] args)
        {
            // Console.WriteLine(Averages("Викентий хорошо отметил день рождения: покушал пиццу, посмотрел кино, пообщался со студентами в чате"));
            // Console.WriteLine(Doubler("написать программу, которая", "описание"));
            // Console.WriteLine(LowerCase("Антон хорошо начал утро: послушал Стинга, выпил кофе и посмотрел Звёздные Войны"));
            // Console.WriteLine(Validator("я плохо учил русский язык. забываю начинать предложения с заглавной. хорошо, что можно написать программу!"));
            Console.ReadKey();
        }


        public static int Averages(string str)
        {

            string[] splited = str.Split(PUNCTUATION.ToCharArray(),
                                         StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;
            foreach (var s in splited)
            {
                sum += s.Length;
            }

            return sum / splited.Length; // with rounding
        }

        public static string Doubler(string str, string key)
        {
            char[] chars = key.ToCharArray();
            HashSet<char> _chars = new HashSet<char>(chars);

            StringBuilder outStr = new StringBuilder(str);

            foreach (var c in _chars)
            {
                string _c = c.ToString();
                outStr.Replace(_c, _c + _c);
            }
            return outStr.ToString();
        }

        public static int LowerCase(string str)
        {
            string[] splited = str.Split(PUNCTUATION.ToCharArray(),
                                         StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;

            foreach (var s in splited)
            {
                if (!Char.IsUpper(s[0]))
                {
                    sum++;
                }
            }
            return sum;
        }

        public static string Validator(string str)
        {
            StringBuilder _str = new StringBuilder(str);

            _str[0] = Char.ToUpper(_str[0]);;

            for (int i = 0; i < _str.Length - 1; i++)
            {
                if (_str[i].Equals('.') || _str[i].Equals('!') || _str[i].Equals('?'))
                {
                    if (_str[i + 1].Equals(' '))
                    {
                        _str[i + 2] = Char.ToUpper(_str[i + 2]);
                    }
                    else _str[i + 1] = Char.ToUpper(_str[i + 1]);
                }
            }
            return _str.ToString();
        }
    }
}
