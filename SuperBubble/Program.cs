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

    class Program
    {
        /// <summary>
        /// Fills the array given as parameter with random values
        /// </summary>
        /// <param name="tab"></param>
        static void initTableau(int[] tab)
        {
            Random rnd = new Random();
            for (int i = 0; i < tab.Length; i++)
                tab[i] = rnd.Next(0, 10000);
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

        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, voici un super BubbleSort\n");
            int[] tab = new int[1024];
            initTableau(tab);
            DisplayTableau(tab, 16);
            //TriTableau(tab);
            Console.ReadKey();
        }

        private static void TriTableau(int[] tab)
        {
            throw new NotImplementedException();
        }
    }
}
