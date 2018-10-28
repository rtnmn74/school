using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace Program {

    class Program {

        static void Main (string[] args) {
            Program program = new Program ();
            program.Item = Enumerable.Range (1, 111111500).ToArray();
            program.find (1123451);
        }

        int[] item;
        public int[] Item { get; set; }

        public bool find (int testValue) {

            Stopwatch stopwatch = new Stopwatch ();
            stopwatch.Start ();

            int intialValue = Item[Item.Length - 1];
            Item[Item.Length - 1] = testValue;
            int i = 0;
            while (Item[i] != testValue) {
                i++;
            }
            Item[Item.Length - 1] = intialValue;

            stopwatch.Stop ();
            Console.WriteLine("Time elapsed: {0}", stopwatch.ElapsedMilliseconds);

            return i < Item.Length - 1 || testValue == intialValue;

        }

    }

}