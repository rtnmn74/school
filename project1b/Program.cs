using System;
using NUnit.Framework;

namespace Project1 {
    /* Class for Square2 */
    class Square2 {

        private int width;
        private int length;

        /*Parameters */
        public int Width { get => width; set => width = value; }
        public int Length { get => length; set => length = value; }

        /* Routine that computes the area of a square  */
        public virtual int computeArea () {
            /* Return area of the square if width and length are not equal */
            /* Throw an exception if width and length are equal */
            if (Width != Length) {
                throw new System.ArgumentException ("Square width and length values must match", "square.Width and square.Length");
            } else
            /* Return the area of a square by multiplying the width x the length */
            {
                return Width * Length;
            }
        }

        /* Routine that computes the perimeter of a square */
        public virtual int computePerimeter ()
        /* Return perimeter of the square if the width and length are not equal */
        /* Throw and exception if the width and length are equal */
        {
            if (Width != Length) {
                throw new System.ArgumentException ("Square width and length values must match", "square.Width and square.Length");
            } else

            {
                /* Return the perimeter of the square by adding 2 times the width with 2 times the length  */
                return Width + Width + Length + Length;
            }
        }

    }
    /* Subclass for Rectangle2 */
    class Rectangle2 : Square2 {

        /* Routine that computes the area of a rectangle */
        public override int computeArea ()
            /* Return the area of a rectangle by multplying the width x the length */
            {
                return Width * Length;
            }

        /* Routine that computes the area of a rectangle */
        public override int computePerimeter () 
            /* Return the perimeter of a rectangle by adding the 2 times the width with 2 times the length */
            {
                return Width + Width + Length + Length;
        }

    }

    /* Tests */
    [TestFixture]
    class RectangleAreaTest {
        [Test]
        public void testRectangleArea () {
            /* Given new rectangle with a width of 150 and a length of 50, compute the area */
            var rectangle = new Rectangle2 ();
            rectangle.Width = 150;
            rectangle.Length = 50;
            var result = rectangle.computeArea ();

            /* The area calculation of 150 and 50 should be 7500 */
            Assert.That (result, Is.EqualTo (7500));
        }

        class RectanglePerimeterTest {
            [Test]
            public void testRectanglePerimeter () {
                /* Given new rectangle with a width of 150 and a length of 50, compute the perimeter */
                var rectangle = new Rectangle2 ();
                rectangle.Width = 150;
                rectangle.Length = 50;
                var result = rectangle.computePerimeter ();

                /* The perimeter calculation of 150 and 50 should be 400 */
                Assert.That (result, Is.EqualTo (400));
            }

        }
        class SquareAreaTest {
            [Test]
            public void testSquareArea () {
                /* Given a new square with a width of 50 and a length of 50, compute the area */
                var square = new Square2 ();
                square.Width = 50;
                square.Length = 50;
                var result = square.computeArea ();

                /* The area calculation of 50 and 50 should be 2500 */
                Assert.That (result, Is.EqualTo (2500));
            }
        }
        class SquarePerimeterTest {
            [Test]
            public void testSquarePerimeter () {
                /* Given new square with a width of 50 and a length of 50, compute the perimeter */
                var square = new Square2 ();
                square.Width = 50;
                square.Length = 50;
                var result = square.computePerimeter ();

                /* The perimeter calculation of 50 and 50 should be 200 */
                Assert.That (result, Is.EqualTo (200));
            }

        }

        class SquareAreaExceptionTest {
            [Test]
            public void testSquareAreaException () {
                /* Given new square with a width of 51 and a length of 50, compute the area */
                var square = new Square2 ();
                square.Width = 51;
                square.Length = 50;

                /* The area calcualtion of 51 and 50 should throw an exception */
                var ex = Assert.Throws<System.ArgumentException> (() => square.computeArea ());
                Assert.That (ex.Message, Is.EqualTo ("Square width and length values must match\r\nParameter name: square.Width and square.Length"));
            }

        }
        class SquarePerimeterExceptionTest {
            [Test]
            public void testSquarePerimeterException () {
                /* Given new square with a width of 51 and a length of 50, compute the perimeter */
                var square = new Square2 ();
                square.Width = 51;
                square.Length = 50;

                /* The perimeter calcualtion of 51 and 50 should throw an exception */
                var ex = Assert.Throws<System.ArgumentException> (() => square.computePerimeter ());
                Assert.That (ex.Message, Is.EqualTo ("Square width and length values must match\r\nParameter name: square.Width and square.Length"));
            }

        }

    }

}