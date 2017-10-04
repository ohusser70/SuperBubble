/*
 *  Super implémentation de Bubble Sort
 * 
 *  vraiment trop bonne
 * 
 * */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBubble
{

    public class Program
    {
        /// <summary>
        /// Fills the array given as parameter with random values
        /// </summary>
        /// <param name="tab"></param>
        static public void initTableau(int[] tab)
        {
            Random rnd = new Random();
            for (int i = 0; i < tab.Length; i++)
                tab[i] = rnd.Next(0, 1000000);
        }

        /// <summary>
        /// Displays the first elements of the int array
        /// </summary>
        /// <param name="tab">Array with integer values</param>
        /// <param name="iMax">the last index to be displayed</param>
        static void DisplayTableau(int[] tab, int iMax)
        {
            for (int i = 0 ; i < iMax; i++)
                Console.Write($" {tab[i]}");
        }

        /// <summary>
        /// Basic (naive) example of implementation of Bubblesort
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Stopwatch chrono = new Stopwatch();

            Console.WriteLine("Hello, this is an awesome Sort Algorithm\n");
            Console.WriteLine("Please give the size of array: ");
            int size = System.Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[size];
            initTableau(tab);
            Console.WriteLine("\nAvant le tri: ");
            DisplayTableau(tab, 10);
            chrono.Start();
            InsertionSort(tab);//BubbleSort(tab);
            chrono.Stop();
            Console.WriteLine($"\nAPRES le tri ({chrono.ElapsedMilliseconds}ms)  : ");
            DisplayTableau(tab, 10);
            Console.ReadKey();
        }

        /// <summary>
        /// Will sort the array given as parameter with the bubblesort algorithm
        /// complexity O(n^2), stable.
        /// </summary>
        /// <param name="Tab"></param>
        public static void BubbleSort(int[] Tab)
        {
            // remonte un élément à chaque fois
            for (int i=0; i< Tab.Length;i++)
            {
                for (int j=Tab.Length-1; j > i;j--) // optimized
                //for (int j =  1; j <= tab.Length; j++)
                    {
                    if (Tab[j] < Tab[j -1])
                        Exchange(ref Tab[j], ref Tab[j - 1]);
                }
            }
        }

        /// <summary>
        /// Will sort the array with the Insertion Sort Algorithm
        /// This implementation take advantage of the short-circuit AND operator (&&) 
        /// won't work if using & instead
        /// </summary>
        /// <param name="Tab"></param>
        public static void InsertionSort(int[] Tab)
        {
            for (int i=1;i<Tab.Length;i++)
            {
                int save = Tab[i];
                int j = i - 1;
                while (( j>= 0) && (Tab[j]>save))   // conditional evaluation of rhs
                {
                    Tab[j + 1] = Tab[j];
                    j--;
                }
                Tab[j + 1] = save;   // Insertion of new element
            }
        }

        public static void Exchange(ref int A, ref int B)
        {
            int temp = A;
            A = B;
            B = temp;
        }

    }
}
