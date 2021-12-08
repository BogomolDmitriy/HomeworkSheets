using System;

namespace LibraryHomeworkSheets
{
    public class Sheets
    {
        public static int[] Task1(int[] arr, int value)
        {
            int[] newarr = new int[arr.Length + 1];
            newarr[newarr.Length-1] = value;
            for (int i = 0; i < newarr.Length - 1; i++)
            {
                newarr[i] = arr[i];
            }

            arr = newarr;
            return arr;
        }

        public static int[] Task2
            (int[] arr, int value)
        {
            int[] newarr = new int[arr.Length + 1];
            newarr[0] = value;
            for (int i = 1; i < newarr.Length; i++)
            {
                newarr[i] = arr[i - 1];
            }

            arr = newarr;
            return arr;
        }

        public static int [] Task3( int[] arr, int value, int index)
        {
            int[] newarr = new int[arr.Length + 1];
            newarr[index] = value;
            for (int i = 0; i < index; i++)
            {
                newarr[i] = arr[i];
            }

            for (int i = index; i < arr.Length; i++)
            {
                newarr[i + 1] = arr[i];
            }

            arr = newarr;
            return arr;
        }

        public static int[] Task4(int[] arr)
        {
            int[] newarr = new int[arr.Length - 1];
            for (int i = 0; i < newarr.Length; i++)
            {
                newarr[i] = arr[i];
            }

            arr = newarr;
            return arr;
        }

        public static int[] Task5(int[] arr)
        {
            int[] newarr = new int[arr.Length - 1];
            for (int i = 0; i < newarr.Length; i++)
            {
                newarr[i] = arr[i+1];
            }

            arr = newarr;
            return arr;
        }

        public static int[] Task6(int[] arr, int index)
        {
            int[] newarr = new int[arr.Length - 1];
            for (int i = 0; i < index; i++)
            {
                newarr[i] = arr[i];
            }

            for (int i = index + 1; i < arr.Length; i++)
            {
                newarr[i - 1] = arr[i];
            }

            arr = newarr;
            return arr;
        }

        public static int[] Task7 (int[] arr, int number)
        {
            int[] newarr = new int[arr.Length - number];
            for (int i = 0; i < newarr.Length; i++)
            {
                newarr[i] = arr[i];
            }

            arr = newarr;
            return arr;
        }

        public static int[] Task8(int[] arr, int number)
        {
            int[] newarr = new int[arr.Length - number];
            for (int i = 0 ; i < newarr.Length; i++)
            {
                newarr[i] = arr[i + number];
            }

            arr = newarr;
            return arr;
        }

        public static int[] Task9(int[] arr, int beginning, int end)
        {
            int[] newarr = new int[arr.Length - (end - beginning+1)];
            for (int i = 0; i < beginning; i++)
            {
                newarr[i] = arr[i];
            }

            for (int i = end+1; i < arr.Length; i++)
            {
                newarr[i -(end)] = arr[i];
            }

            arr = newarr;
            return arr;
        }
    }
}
