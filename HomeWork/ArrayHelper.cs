
using System;

namespace HomeWork
{
    public static class ArrayHelper
    {
        public static int FindMaxValue (int [] array)
        {
            int maxvalue = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxvalue)
                {
                    maxvalue = array[i];
                }
            }
            return maxvalue;
        }

        public static int FindMinValue(int[] array)
        {
            int minvalue = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minvalue )
                {
                    minvalue = array[i];
                }
            }
            return minvalue;
        }
        public static int[] CreateArrayRandom (int arrayLength)
        {
            var array = new int[arrayLength];
            var random = new Random();
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = random.Next(10);
            }
            return array;
        }
        public static void PrintArray(int[] array)
        {
            Console.Write("Массив чисел: ");
            for (int i = 0; i < array.Length; i++)
            {
               Console.Write(array[i]);
               if (i < array.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();
        }
        public static int FindGeneralSumm(int[] array)
        {
            int summ =0;
            for (int i = 0; i < array.Length; i++)
            {
                summ += array[i];
            }
            return summ;
        }
        public static double FindSumm(int[] array)
        {
            double summ = 0;
            double final = 0;
            for (int i = 0; i < array.Length; i++)
            {
                summ += array[i];

                final = summ / array.Length;
            }
            return final;
        }

        public static int[] MyReverse(int[] array)
        {
            int[] reverseArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                reverseArray[i] = array[array.Length - i - 1];
            }
            return reverseArray;
        }

        public static int[] SubArray(int [] array, int from, int count)
        {
            int[] arrayPart = new int[count];
            Console.WriteLine("Массив чисел с " + from +  " элемента, массива, размерностью в " + count +  " равен: ");

            for (int i = 0; i < arrayPart.Length; i++)
            {
                if (i >= from && i <= array.Length-1)
                {
                    arrayPart[i] = array[i];
                }
                else if (i < from)
                {
                    arrayPart[i] = 0;
                }
                else  
                {
                    arrayPart[i] = 1;
                }
            }
            return arrayPart;
        }

        public static int[] ArrayLengthPlus (int[] array)
        {
            int[] arrayPlus = new int[array.Length+1];

            for (int i = 0; i < array.Length; i++)
            {
                arrayPlus[i] = array[i];
            }
            return arrayPlus;
         }

        public static int[] ArrayChange(int[] array, int value)
        {
            int[] arrayNew = new int[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                arrayNew[0] = value;
                arrayNew[i + 1] = array[i]; 
            }
            return arrayNew;
        }
    }
}
