/*
 *  Super implémentation de Bubble Sort
 * 
 *  vraiment trop bonne
 * 
 * */
using System;
using System.Collections.Generic;
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
                tab[i] = rnd.Next(0, 1000);
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
            Console.WriteLine("Hello, this is the awesome BubbleSort\n");
            Console.WriteLine("Please give the size of array: ");
            int size = System.Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[size];
            initTableau(tab);
            Console.WriteLine("\nAvant le tri: ");
            DisplayTableau(tab, size);
            TriTableau(tab);
            Console.WriteLine("\nAPRES le tri: ");
            DisplayTableau(tab, size);
            Console.ReadKey();
        }

        /// <summary>
        /// Will sort the array given as parameter with the bubblesort algorithm
        /// complexity O(n^2), stable.
        /// </summary>
        /// <param name="Tab"></param>
        public static void TriTableau(int[] Tab)
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

        public static void Exchange(ref int A, ref int B)
        {
            int temp = A;
            A = B;
            B = temp;
        }

    }
}
