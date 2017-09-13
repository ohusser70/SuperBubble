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
        static void initTableau(int[] tab)
        {
            Random rnd = new Random();
            for (int i = 0; i < tab.Length; i++)
                tab[i] = rnd.Next(0, 10000);
        }

        static void DisplayTableau(int[] tab)
        {
            for (int i = 0; i < 16; i++)
                Console.Write($" {tab[i]}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, voici un super BubbleSort\n");
            int[] tab = new int[1024];
            initTableau(tab);
            DisplayTableau(tab);

            Console.ReadKey();
        }
    }
}
