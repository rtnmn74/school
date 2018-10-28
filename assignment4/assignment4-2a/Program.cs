using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            bool found = false;
            int i = 0;
            while ((!found) && (i < Item.Length)) {
                if (Item[i] == testValue)
                    found = true;
                else
                    i++;
            }

            stopwatch.Stop ();
            Console.WriteLine ("Time elapsed: {0}", stopwatch.ElapsedMilliseconds);

            return found;

        }

    }

}