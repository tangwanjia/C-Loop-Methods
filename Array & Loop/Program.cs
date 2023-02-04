using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab3_a;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Lab3 implemented by Wanjia Tang \n");

        Console.WriteLine("The initial unsorted integer array is:");
        int[] numbers = helper.GenerateIntArrayWithRandValue(100);
        //call the function of GIA
        helper.PrintIntArrayToConsole(numbers);


        int[] index = helper.GenerateIntArrayWithRandValue(100);
        numbers.CopyTo(index, 0); //copy from the first array,first parameter is the orignial array, second is start from..

        int swaps = helper.bubbleSort(index);
        Console.WriteLine("Buble Sort made " + swaps + " swaps to sort the data");
        helper.PrintIntArrayToConsole(index);

        string answer = "Y";
        while (answer is "Y" ) //back to step e and do the loop
        {
            Console.Write("enter an integer to search:");
            int num = Convert.ToInt32(Console.ReadLine());
            int numOfComparison;      
            int lsResult = helper.LinearSearch(numbers, num, out numOfComparison);
            //call linear search

            if (lsResult != 0)
            {
               Console.WriteLine("Linear search made " + numOfComparison + " comparisons to find out that" + num + " is at index " + (num - 1) + " in this unsorted array \n");
            };
            
            int bsResult = helper.BinarySearch( index , swaps, out numOfComparison);
            if (bsResult != 0)
            {
                Console.WriteLine("Binary search made " + numOfComparison + " comparisons to find out that" + num + " is at index" + (num - 1) + " in this unsorted array \n");           
            };
            Console.WriteLine("Would you like to search another integer?(Y/N)");
            answer = Console.ReadLine();
        } 
    }
}
 
