using System;

namespace Epam.Task_2._1._1.CUSTOM_STRING
{
    internal class MyString
    {
        private char[] str;
        private int count = 16;

        public MyString()
        {
            str = new char[count];
        }

        public MyString(int size)
        {
            str = new char[count];
            if (size > count)
            {
                count = size;
            }
        }

        public MyString(char[] arr)
        {
            str = new char[count];
            while (arr.Length > count)
            {
                GenerateNewArray();
            }

            for (int i = 0; i < arr.Length; i++)
            {
                str[i] = arr[i];
            }
        }

        public MyString(string s)
        {
            str = new char[count];
            while (s.Length > count)
            {
                GenerateNewArray();
            }

            for (int i = 0; i < s.Length; i++)
            {
                str[i] = s[i];
            }
        }

        public int Length => str.Length;

        public char this[int index]
        {
            get
            {
                if (index <= Length)
                {
                    return str[index];
                }

                throw new ArgumentException("Value is more than Length");
            }

            set
            {
                if (index > Length)
                {
                    throw new ArgumentException("Index is more than Length");
                }

                str[index] = value;
            }
        }

        public static explicit operator MyString(char[] arr)
        {
            return new MyString(arr);
        }

        public static explicit operator string(MyString myStr)
        {
            return new string((char[])myStr);
        }

        public static explicit operator MyString(string str)
        {
            return new MyString(str);
        }

        public static explicit operator char[](MyString myStr)
        {
            char[] res = new char[myStr.Length];
            for (int i = 0; i < myStr.Length; i++)
            {
                res[i] = myStr.str[i];
            }

            return res;
        }

        public static MyString operator +(MyString s1, MyString s2)
        {
            int l = s1.str.Length + s2.str.Length;

            var sumstr = new MyString(l);

            for (int i = 0; i < s1.str.Length; i++)
            {
                sumstr[i] = s1[i];
            }

            for (int i = 0; i < s2.str.Length; i++)
            {
                sumstr[s1.str.Length + i] = s2[i];
            }

            return sumstr;
        }

        public static bool operator ==(MyString s1, MyString s2)
        {
            if (s1.str.Length != s2.str.Length)
            {
                return false;
            }

            for (int i = 0; i < s1.str.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator !=(MyString s1, MyString s2)
        {
            return !(s1 == s2);
        }

        public override bool Equals(object obj)
        {
            if (obj is MyString)
            {
                return obj == str;
            }

            return false;
        }

        public override int GetHashCode()
        {
            int ans = 0;
            for (int i = 0; i < Length; i++)
            {
                ans ^= str.GetHashCode();
            }

            return ans;
        }

        public char[] Remove(int kol, int pos)
        {
            while (kol > 0)
            {
                for (int i = pos; i < Length - 1; i++)
                {
                    str[i] = str[i + 1];
                }

                kol--;
            }

            return str;
        }

        public override string ToString()
        {
            return new string(str);
        }

        public void Insert(int pos, string s)
        {
            int k = Length;
            while (s.Length + k > count)
            {
                GenerateNewArray();
            }

            for (int i = 0; i < s.Length; i++)
            {
                str[k] = str[pos];
                str[pos] = s[i];
                pos++;
                k++;
            }
        }

        private void GenerateNewArray()
        {
            count *= 2;
            var temp = new char[count];
            for (int i = 0; i < str.Length; i++)
            {
                temp[i] = str[i];
            }

            str = temp;
        }
    }
}
