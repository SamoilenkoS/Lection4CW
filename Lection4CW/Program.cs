using System;

namespace Lection4CW
{
    class Program
    {

        //Update array: odd elements add first element value, even elements replace with first
        //element value.
        //Do not change the first and last elements

        static bool IsOrdered(int[] array)
        {
            bool result = true;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if(array[i] > array[i + 1])
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Reverse(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                Swap(ref array[i], ref array[array.Length - 1 - i]);
            }
        }

        static void SortAscending1(int[] array)
        {
            for (int j = 0; j < array.Length; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(ref array[i], ref array[i + 1]);
                    }
                }
            }
            
        }

        static void SortAscending(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[i] > array[j])
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
        }

        static void UpdateArray(int[] array)
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                if(array[i] % 2 == 0)
                {
                    array[i] = array[0];
                }
                else
                {
                    array[i] += array[0];
                }
            }
        }

        static double GetArrayMedianValue(int[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum / array.Length;
        }

        static int GetPositiveNumbersCount(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > 0)
                {
                    count++;
                }
            }

            return count;
        }

        static int SumBetweenMaxAndMin(int[] array)
        {
            int minI = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] < array[minI])
                {
                    minI = i;
                }
            }

            int maxI = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[maxI])
                {
                    maxI = i;
                }
            }

            if(maxI < minI)
            {
                Swap(ref minI, ref maxI);
            }

            int sum = 0;
            for (int i = minI + 1; i < maxI; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine(SumBetweenMaxAndMin(array));
        }
    }
}
