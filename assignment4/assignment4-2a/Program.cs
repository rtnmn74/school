using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Program {

    class Program {
        //*Main method */
        static void Main (string[] args) {
            /*Construct a new program */
            Program program = new Program ();
            /*Set Item array to a large range from 1 to 111111500  */
            program.Item = Enumerable.Range (1, 111111500).ToArray ();
            /*Input a test value into the find method */
            program.find (1123451);
        }
        //*Define item array */
        int[] item;
        //*Define property for item arrary */
        public int[] Item { get; set; }
        //*Method to find a number in a the Item array where testValue is the number to find */
        public bool find (int testValue) {
            //*Stopwatch timer to measure find method performance */
            Stopwatch stopwatch = new Stopwatch ();
            //*Start stopwatch timer */
            stopwatch.Start ();
            //*Set boolean variable found with a starting value of false */
            bool found = false;
            //*Set loop count variable i with a starting value of 0  */
            int i = 0;
            //*While testValue not found and loop count less than Item array total length compare item array value with testValue */
            while ((!found) && (i < Item.Length)) {
                //*Compare item array value with testValue */
                if (Item[i] == testValue)
                    //*If match then set boolean variable found as true */
                    found = true;
                //*If no match continue loop until found or finished looping through array then false  */    
                else
                    i++;
            }
            //*Stop stopwatch timer */
            stopwatch.Stop ();
            //*Write stopwatch time to console in milliseconds */
            Console.WriteLine ("Time elapsed: {0}", stopwatch.ElapsedMilliseconds);
            //*Return found varialble value true or false */
            return found;

        }

    }

}