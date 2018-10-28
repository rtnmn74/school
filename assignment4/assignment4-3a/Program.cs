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
            /*Input 100000000 iterations into the ComputeSum method */
            program.ComputeSum (100000000);
        }
        //*Method to cumpute the sum of iterations */
        public double ComputeSum (int numIterations) {
            //* Define compute index variable */
            int computeIndex;
            //*Stopwatch timer to measure find method performance */
            Stopwatch stopwatch = new Stopwatch ();
            //*Start stopwatch timer */
            stopwatch.Start ();
            //*define sum variable and set to zero */
            double sum = 0.0;
            //*Loop to add one to sum at each iteration until all iterations have ran */
            for (computeIndex = 0; computeIndex < numIterations; computeIndex++) {
                sum += 1.0;
            }
            //*Stop stopwatch timer */
            stopwatch.Stop ();
            //*Write stopwatch time to console in milliseconds */
            Console.WriteLine ("Time elapsed: {0}", stopwatch.ElapsedMilliseconds);
            //*Return found variable value true or false */
            return sum;
        }
    }
}