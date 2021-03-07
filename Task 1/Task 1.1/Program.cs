using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Rectangle(4, 1));
            // Triangle(5);
            // AnotherTriangle(11);
            // XmasTree(3);
            // Console.WriteLine(SumOfNumbers(1000));
            // FontAdjustment();
            // ArrayProcessing();
            // NoPositive(RandomArray(10, 10, 10));
            // Console.WriteLine(NonNegativeSum(RandomArray(20)));
            // Console.WriteLine(TwoDArray(RandomArray(10, 10)));
            Console.ReadKey();
        }

        public static double Rectangle(int a, int b)
        {
            try
            {
                if (a <= 0 || b <= 0) throw new Exception("Args must be greater than 0");
                return a * b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }
        public static void Triangle(int N, char sym = '*')
        {
            try
            {
                if (N <= 0) throw new Exception("Arg must be greater than 0");

                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine(new String(sym, i));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void AnotherTriangle(int N, int offset = 0, char sym = '*')
        {
            try
            {
                if (N <= 0) throw new Exception("Arg must be greater than 0");
                int maxLetters = N * 2 - 1, i = 1;
                while (i <= maxLetters)
                {
                    int spaces = (maxLetters - i) / 2;
                    Console.WriteLine(new String(' ', spaces + offset) + new String(sym, i) + new String(' ', spaces));
                    i += 2;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void XmasTree(int N, char sym = '*')
        {
            try
            {
                if (N <= 0) throw new Exception("Arg must be greater than 0");
                for (int i = 0; i <= N; i++)
                {
                    AnotherTriangle(i + 1, N - i, sym);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        private static int _SumOfNumbers(int num, int m)
        {
            int n = (num - 1) / m;
            return (m * 2 + m * (n - 1)) * n / 2;
        }
        public static int SumOfNumbers(int N)
        {
            try
            {
                if (N <= 0) throw new Exception("Arg must be greater than 0");
                return (_SumOfNumbers(N, 3) + _SumOfNumbers(N, 5) - _SumOfNumbers(N, 3 * 5));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }
        public static void FontAdjustment() {
            Dictionary<string, bool> fontProps = new Dictionary<string, bool>() {
                { "bold", false },
                { "italic", true },
                { "underline", true }
            };
            List<string> active = new List<string>();
            List<string> keys = new List<string>(fontProps.Keys);
            
            while (true)
            {
                active.Clear();
                
                foreach (KeyValuePair<string, bool> fp in fontProps) {
                    if (fp.Value) active.Add(Char.ToUpper(fp.Key[0]) + fp.Key.Remove(0, 1));
                }
                Console.WriteLine($"Параметры надписи: { (active.Count == 0 ? "None" : String.Join(", ", active.ToArray())) }");

                Console.WriteLine("Введите:");
                for(int i = 0; i < keys.Count; i++) {
                    Console.WriteLine($"\t{ i + 1 }: { keys[i] }");
                }
                
                try {
                    int action = Convert.ToInt32(Console.ReadLine());

                    if (action == 0) break;

                    string key = keys[action - 1];

                    fontProps[key] = !fontProps[key];
                }
                catch {
                    Console.WriteLine("Wrong argument");
                }
                
            }
        }
        private static int[] RandomArray(int d1)
        {
            Random random = new Random();
            int[] arr = new int[d1];
            for (int i = 0; i < d1; i++)
            {
                arr[i] = random.Next(-50, 50);
            }
            return arr;
        }
        private static int[,] RandomArray(int d1, int d2)
        {
            Random random = new Random();
            int[,] arr = new int[d1, d2];
            for (int i = 0; i < d1; i++)
            {
                for (int j = 0; j < d2; j++)
                {
                    arr[i, j] = random.Next(-50, 50);
                }
            }

            return arr;
        }
        private static int[,,] RandomArray(int d1, int d2, int d3)
        {
            Random random = new Random();
            int[,,] arr = new int[d1, d2, d3];
            for (int i = 0; i < d1; i++)
            {
                for (int j = 0; j < d2; j++)
                {
                    for (int k = 0; k < d2; k++)
                    {
                        arr[i, j, k] = random.Next(-50, 50);
                    }
                }
            }

            return arr;
        }
        private static void Sort(int[] arr)
        {
            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        int tmp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = tmp;
                        swapped = true;
                    }
                }
            }
        }
        public static void ArrayProcessing()
        {
            int[] arr = RandomArray(10);

            Console.WriteLine("Initial -> " + String.Join(", ", arr));

            Sort(arr);

            Console.WriteLine("Sorted -> " + String.Join(", ", arr));
            Console.WriteLine("Max -> " + Convert.ToString(arr[0]));
            Console.WriteLine("Min -> " + Convert.ToString(arr[arr.Length - 1]));
        }
        public static void NoPositive(int[,,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        if (arr[i, j, k] > 0) arr[i, j, k] = 0;
                    }
                }
            }
        }
        public static int NonNegativeSum(int[] arr)
        {
            int sum = 0;

            foreach (int i in arr)
            {
                if (i > 0) sum += i;
            }

            return sum;
        }
        public static int TwoDArray(int[,] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int k = 0; k < arr.GetLength(1); k++)
                {
                    if ((i + k) % 2 == 0)
                    {
                        sum += arr[i, k];
                    }
                }
            }

            return sum;
        }
    }
}
