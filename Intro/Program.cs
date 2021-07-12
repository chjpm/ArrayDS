using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration of an array
            int[] intArray;

            //Allocation of memory
            intArray = new int[5];

            //initializing first element of array
            intArray[0] = 10;

            //initializing second element of array
            intArray[1] = 20;

            //so on...
            intArray[2] = 30;
            intArray[3] = 40;
            intArray[4] = 50;

            //Accessing array elements
            //Using for loop
            Console.WriteLine("For loop: ");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(" " + intArray[i] );
            }

            //Using foreach loop
            Console.WriteLine(" ");
            Console.WriteLine("Foreach loop: ");
            foreach (int i in intArray)
            {
                Console.WriteLine(" " + i);
            }

            //Using while loop
            Console.WriteLine(" ");
            Console.WriteLine("While loop: ");
            int j = 0;
            while (j < intArray.Length)
            {
                Console.WriteLine(" " + intArray[j]);
                j++;
            }

            //Using do-while loop
            Console.WriteLine("");
            Console.WriteLine("Do-While loop: ");
            int k = 0;
            do
            {
                Console.WriteLine(" " + intArray[k]);
                k++;
            } while (k < intArray.Length);

            Console.ReadLine();
        }
    }
}
