using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        public static void Drop3(int[] XRay)
        {
            for (int i=0; i<XRay.Length; i++)
            {
                if (XRay[i] % 3 == 0)
                {
                    Console.WriteLine($"{XRay[i]} ia a multiple of 3");
                }
                else
                {
                    Console.WriteLine($"{XRay[i]} ");
                }//else
            }//for
        }//Drop3


        //public static void RevArray(int[] XRay) {
        //    {
        //        //Sadly, this is flawed... halfway through it starts mirroring itself
        //        int j = XRay.Length-1;
        //        int tmpBeginFirst = XRay[0];
        //        int tmpBeginLast  = XRay[XRay.Length-1];
        //        for (int i=0; i<XRay.Length; i++)
        //        {
        //            XRay[i] = XRay[j];
        //            Console.WriteLine($"i:{i}, j:{j} Values i:{XRay[i]} j:{XRay[j]} ");
        //            j--;
        //         }
        //        int tmpAfterFirst = XRay[0];
        //        int tmpAfterLast  = XRay[XRay.Length - 1];
        //        Console.WriteLine($"Begin Indx0:{tmpBeginFirst}, Indx0:{tmpAfterFirst} ");
        //        Console.WriteLine($"After Indx49:{tmpBeginLast}, Indx49:{tmpAfterLast} ");
        //        Console.ReadLine();
        //    }
        //    Console.ReadLine();
        //}//RevArray


        public static void RevArray(int[] XRay)
        {
            int left = 0;
            int right = XRay.Length - 1;
        
            while (left < right)
            {
                // Swap XRay[left] and XRay[right]
                int temp = XRay[left];
                XRay[left] = XRay[right];
                XRay[right] = temp;
       
                // Move the pointers towards each other
                left++;
                right--;
            }
        }


        public static void BarfRand(int[] XRay) {
            int tmpRand = 0;
            var rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                tmpRand = rand.Next(0,50);
                Console.WriteLine($"Array Random: {tmpRand}");
                XRay[i] = tmpRand;
                Console.ReadLine();
            }
         }

        public static void ArrayPrinter(int[] array1)
        { 
            for (int i = 0; i<array1.Length; i++)
                Console.WriteLine($"{array1[i]}");
        }

        public static void ListPrinter(List<int> Alist)
        {
            for (int i = 0; i < Alist.Count; i++)
                Console.WriteLine($"Method Print List: {Alist[i]} ");
        }


    static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] XRay = new int[50];
            List<int> AList = new List<int>();

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Console.WriteLine($"#1 Fill Array with Random Numbers: ");
            Console.ReadLine();
            BarfRand(XRay);
            int firstNbr = XRay[0];
            int lastNbr =  XRay[XRay.Length-1];

            //TODO: Print the first number of the array
            Console.WriteLine("#2 Press Return To Continue> ");
            Console.WriteLine($"XRay First number: {XRay[0]}");
            Console.ReadLine();


            //TODO: Print the last number of the array
            Console.WriteLine("#3 Press Return To Continue> ");
            Console.WriteLine($"XRay Last number: {XRay[XRay.Length - 1]}");
            Console.ReadLine();



            //UNCOMMENT this method to print out your numbers from arrays or lists
            Console.WriteLine("#4 Press Return To Continue> ");
            Console.WriteLine("All Original Order Random Numbers ");
            Console.ReadLine();
            ArrayPrinter(XRay);
            Console.WriteLine($"Last Number Should be: {lastNbr} ");
            Console.ReadLine();

            List<int> Alist = new List<int>() {1, 2, 3, 4, 5 };
            Console.WriteLine("#5 Press Return To Continue> ");
            Console.WriteLine("Print List> ");
            ListPrinter(AList);
            Console.WriteLine("-------------------");
            for (int i = 0;i < Alist.Count;i++)
            {
                Console.WriteLine($"Print List: {Alist[i]} ");
            }


            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            Console.WriteLine("#6 Press Return To Continue> ");
            Console.WriteLine("#6 All Numbers Reversed Again:");
            Console.ReadLine();
            Array.Reverse(XRay);
            ArrayPrinter(XRay);
            Console.WriteLine($"#6 Last Number Should be the first Nbr: {firstNbr} ");
            Console.ReadLine();
            Console.WriteLine(" #6 Done, Press Return To Continue> ");




            Console.WriteLine("#7 Press Return To Continue> ");
            Console.WriteLine("#7-Calling RevArray----REVERSING CUSTOM------------");
            RevArray(XRay);
            Console.WriteLine("#7--RevArray Exit-------REVERSING CUSTOM Complete------------");
            Console.ReadLine();

            Console.WriteLine("#8 Printing the Array> ");
            Console.WriteLine("#8 Press Return To Continue> ");
            Console.ReadLine();
            ArrayPrinter(XRay);
            Console.WriteLine($"#8 Last Number Should be the last Nbr again: {lastNbr} ");
            Console.WriteLine("#8 Reversal Done -------------------");
            Console.ReadLine();





            //TODO: Create a method that will set numbers that are a multiple
            //of 3 to zero then print to the console all numbers
            Console.WriteLine("#9 Press Return To Continue> ");
            Console.WriteLine("Find Numbers That are Multiple of three: ");
            Console.ReadLine();
            Drop3(XRay);
            Console.WriteLine("#9 End Sort3");
            Console.WriteLine("#9 <----->\n\n\n\n");
            Console.WriteLine("");


            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("#10 Press Return To Continue> ");
            Console.WriteLine("Array Sorted Ascending:");
            Console.ReadLine();
            Array.Sort(XRay);
            ArrayPrinter(XRay);
            Console.WriteLine("#10 End of printing Sorted array");
            Console.WriteLine("#10 <----->\n\n\n\n");
            Console.ReadLine();

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            

            //TODO: Print the capacity of the list to the console
            

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            

            //TODO: Print the new capacity
            

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            

            //TODO: Clear the list
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            
        }

        private static void OddKiller(List<int> numberList)
        {
            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

        }        

        private static void ReverseArray(int[] array)
        {
            
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
