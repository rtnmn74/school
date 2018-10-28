using System;
using System.Diagnostics;

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
            double sum0, sum1, sum2, sum3, sum4, sum5, sum6, sum7;
            //* Define compute index variable */
            int computeIndex;
            //*Stopwatch timer to measure find method performance */
            Stopwatch stopwatch = new Stopwatch ();
            //*Start stopwatch timer */
            stopwatch.Start ();
            //*define sum variable and set to zero */
            double sum = 0.0;
            sum0 = sum1 = sum2 = sum3 = sum4 = sum5 = sum6 = sum7 = 0.0;
            //*Loop to add one to sum at each iteration until all iterations have ran */
            for (computeIndex = 0; (computeIndex+7) < numIterations; computeIndex += 8) {
                sum0 += 1.0; 
                sum1 += 1.0; 
                sum2 += 1.0; 
                sum3 += 1.0; 
                sum4 =+ 1.0; 
                sum5 =+ 1.0;
                sum6 += 1.0;
                sum7 += 1.0; 
            }
            sum = sum0 + sum1 + sum2 + sum3 + sum4 + sum5 + sum6 + sum7;
            for (;computeIndex < numIterations; computeIndex++) {
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