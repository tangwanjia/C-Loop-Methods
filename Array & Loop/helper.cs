using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab3_a
{
    internal class helper
    {
        public static int[] GenerateIntArrayWithRandValue(int sizeOfArray) //random numbers generated
        {
            int[] array = new int[sizeOfArray];
            Random rdn = new Random();

            for (int j = 0; j < sizeOfArray; ++j)
            {
                array[j] = rdn.Next(0,100);

            }
            return array;
        }
        public static void PrintIntArrayToConsole(int[] arrayToPrint)
        {
            int count = 0;
            for (int i = 0; i < arrayToPrint.Length; i++)
            {
                Console.Write(arrayToPrint[i] + " " + "\t");
                count++;
                if (count == 10)
                {
                    Console.WriteLine("\t");
                    count = 0;
                }
            }

        }

        public static int LinearSearch(int[] haystack, int niddle, out int numOfComparison)
        {
           numOfComparison = 0;
            for (int i = 0; i < haystack.Length; i++)
            {
                numOfComparison++;
                if (niddle == haystack[i])
                {
                    return i;
                }   
            }
            return -1;
        }

        public static int bubbleSort (int[] arr)
        {
              int temp;
              int numLength = arr.Length;
              int swaps = 0;
            //sorting an array  
              for (int i = 0; (i < (numLength - 1)); i++)
              { 
               
                for (int j = 0; j < (numLength - j - 1); j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swaps++;
                    }
                }              
              }
              return swaps;

            //Console.WriteLine("Bubble sort made" + " " + "swaps to sort the data" );
            //    //Sorted array  
            //  foreach (int num in arr)
            //  {
            //    Console.Write("\t {0}", num);
            //  }
            //  Console.Read();
            //    return arr;
        }
        public static int BinarySearch(int[] haystack, int niddle, out int numOfComparison)
        {
            int minNum = 0;
            int maxNum = haystack.Length - 1;
            numOfComparison= 0;

            while (minNum <= maxNum)
            {
                int mid = (minNum+maxNum)/2;
                numOfComparison++;
                if (niddle == haystack[mid])
                {
                    return mid;
                }
                else if (niddle < haystack[mid])
                {
                    maxNum = mid - 1;
                }
                else
                { 
                    minNum = mid + 1;      
                }
            }
            return -1;
        }
    }
}
