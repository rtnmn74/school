using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace assignment4 {

    class Program {
        //*Main method */
        static void Main (string[] args) {
            /*Construct a new program */
            Program program = new Program ();
            /*Set Item array to a large range from 1 to 111111500  */
            program.Item = Enumerable.Range (1, 111111500).ToArray ();
            /*Input a test value into the find method */
            program.Find (1123451);
        }
        //*Define item array */
        int[] item;
        //*Define property for item array */
        public int[] Item { get; set; }
        //*Method to find an element in a the Item array where testValue is the number to find */
        public bool Find (int testValue) {
            //*Stopwatch timer to measure find method performance */
            Stopwatch stopwatch = new Stopwatch ();
            //*Start stopwatch timer */            
            stopwatch.Start ();
            //*Set intialValue variable equal to the array item length minus 1 */
            int intialValue = Item[Item.Length - 1];
            //*Set Item array value to Item array length minus 1 equal to testValue */
            Item[Item.Length - 1] = testValue;
            //*Set variable itemIndex with a starting value of 0  */
            int itemIndex = 0;
            //*Repeat increment of itemIndex while Item element itemIndex does not match testValue  */
            while (Item[itemIndex] != testValue) {
                itemIndex++;
            }
            //*Set the Item array element value of Item array length minus 1 equal to intialValue */
            Item[Item.Length - 1] = intialValue;
            //*Stop stopwatch timer */
            stopwatch.Stop ();
            //*Write stopwatch time to console in milliseconds */            
            Console.WriteLine ("Time elapsed: {0}", stopwatch.ElapsedMilliseconds);
            //*Conditionally operator that returns true if out of elements to search or testValue equals initialValue */
            return itemIndex < Item.Length - 1 || testValue == intialValue;

        }

    }

}