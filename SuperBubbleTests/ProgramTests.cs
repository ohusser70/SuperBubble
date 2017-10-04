using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperBubble;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBubble.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void ExchangeTest()
        {
            int A = 2, B = 3;
            SuperBubble.Program.Exchange(ref A, ref B);
            Assert.IsTrue((A == 3) && (B == 2));
            //Assert.Fail();
        }

        [TestMethod()]
        public void BubbleSortTest()
        {
            int[] testArray = new int[32];
            SuperBubble.Program.initTableau(testArray);
            bool sorted = true;
            SuperBubble.Program.BubbleSort(testArray);
            for (int i = 1; i < testArray.Length; i++)
            {
                if (testArray[i] < testArray[i - 1])
                {
                    sorted = false;
                    i = testArray.Length;   // end the for loop (while would be nicer)
                }
            }
            Assert.IsTrue(sorted);
        }

        [TestMethod()]
        public void InsertionSortTest()
        {
            int[] testArray = new int[32];
            SuperBubble.Program.initTableau(testArray);
            bool sorted = true;
            SuperBubble.Program.InsertionSort(testArray);
            for (int i = 1; i < testArray.Length; i++)
            {
                if (testArray[i] < testArray[i - 1])
                {
                    sorted = false;
                    i = testArray.Length;   // end the for loop (while would be nicer)
                }
            }
            Assert.IsTrue(sorted);
        }
    }
}