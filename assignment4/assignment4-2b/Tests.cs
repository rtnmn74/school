using System;
using NUnit.Framework;

namespace assignment4 {
    [TestFixture]
    public class ProgramTests {
        [TestCase]
        public void testFindTrue () {
            Program program = new Program ();
            program.Item = new int[] { 1, 2, 3, 4, 5, 6 };
            bool result = program.find (2);
            Assert.That (result == true);
        }

        [TestCase]
        public void testFindFalse () {
            Program program = new Program ();
            program.Item = new int[] { 1, 2, 3, 4, 5, 6 };
            bool result = program.find (11);
            Assert.That (result == false);
        }
    }
}