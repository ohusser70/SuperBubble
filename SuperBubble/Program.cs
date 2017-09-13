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
        /// Implementation basique d'un tri bulle
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, voici un super BubbleSort\n");
            int[] tab = new int[16];
            initTableau(tab);
            Console.WriteLine("\nAvant le tri: ");
            DisplayTableau(tab, 16);
            TriTableau(tab);
            Console.WriteLine("\nAPRES le tri: ");
            DisplayTableau(tab, 16);
            Console.ReadKey();
        }

        /// <summary>
        /// Effectue le tri bulle du tableau reçu en paramètre
        /// </summary>
        /// <param name="tab"></param>
        private static void TriTableau(int[] tab)
        {
            // remonte un élément à chaque fois
            for (int i=0; i< tab.Length;i++)
            {
                for (int j=tab.Length-1; j > 0;j--)
                {
                    if (tab[j]<tab[j-1])
                    {
                        int temp = tab[j];
                        tab[j] = tab[j - 1];
                        tab[j-1] = temp;
                    }
                }
            }
        }
    }
}
