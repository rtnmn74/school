using System;
using NUnit.Framework;

namespace assignment4 {
    [TestFixture]
    public class ProgramTests {
        [TestCase (1)]
        [TestCase (6)]
        public void testFindTrue (int testNumber) {
            Program program = new Program ();
            program.Item = new int[] { 1, 2, 3, 4, 5, 6 };
            bool result = program.find (testNumber);
            Assert.That (result == true);
        }

        [TestCase (7)]
        [TestCase (0)]
        public void testFindFalse (int testNumber) {
            Program program = new Program ();
            program.Item = new int[] { 1, 2, 3, 4, 5, 6 };
            bool result = program.find (testNumber);
            Assert.That (result == false);
        }
    }
}