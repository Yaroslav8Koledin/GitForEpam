namespace Epam.Task_3._3._1.SUPER_ARRAY
{
    public static class OperationWithArray
    {
        public static int GetSum(this int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }

            return result;
        }

        public static float FindTheMean(this int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }

            return result / arr.Length;
        }

        public static int GetDuplicate(this int[] arr)
        {
            int maxDublicate = 0;
            int elem = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int frequence = GetFrequency(arr, arr[i]);
                if (maxDublicate < frequence)
                {
                    maxDublicate = frequence;
                    elem = arr[i];
                }
            }

            return elem;
        }

        private static int GetFrequency(int[] arr, int item)
        {
            int frequence = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == item)
                {
                    frequence++;
                }
            }

            return frequence;
        }
    }
}
