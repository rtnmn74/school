using System;
using NUnit.Framework;

namespace Project1 {
    /* Class for Rectangle1 */
    class Rectangle1 {
        /* Parameters for a shape with 4 sides */
        public int width;
        public int length;

        /*Contructor for a rectangle */
        public Rectangle1 (int width, int length) {
            this.width = width;
            this.length = length;
        }

        /* Routine that computes the area of a rectangle  */
        public virtual int computeArea () {
            /* Return area of the rectangle if width and length are not equal */
            /* Throw an exception if width and length are equal */
            if (width == length) {
                throw new System.ArgumentException ("Rectangle width and length values cannot match", "rectangle.width and rectangle.length");
            } else
            /* Return the area of a rectangle by multiplying the width x the length */
            {
                return width * length;
            }
        }

        /* Routine that computes the perimeter of a rectangle */
        public virtual int computePerimeter ()
        /* Return perimeter of the rectangle if the width and length are not equal */
        /* Throw and exception if the width and length are equal */
        {
            if (width == length) {
                throw new System.ArgumentException ("Rectangle width and length values cannot match", "rectangle.width and rectangle.length");
            } else

            {
                /* Return the perimeter of the rectangle by adding 2 times the width with 2 times the length  */
                return width + width + length + length;
            }
        }

    }
    /* Subclass for Square1 */
    class Square1 : Rectangle1 {
        /* Contructor for a square */
        public Square1 (int width, int length) : base (width, length) {
            this.width = width;
            this.length = length;
        }

        /* Routine that computes the area of a square */
        public override int computeArea ()
        /* Return arear of the square if the width and length are equal */
        /* Throw and exception if the width and length are not equal */
        {
            if (width != length) {
                throw new System.ArgumentException ("Square width and length values must match", "square.width and square.length");
            } else
            /* Return the area of a square by multplying the width x the length */
            {
                return width * length;
            }

        }
        /* Routine that computes the area of a square */
        public override int computePerimeter () {
            /* Return arear of the square if the width and length are equal */
            /* Throw and exception if the width and length are not equal */
            if (width != length) {
                throw new System.ArgumentException ("Square width and length values must match", "square.width and square.length");
            } else
            /* Return the perimeter of a sqaure by adding the 2 times the width with 2 times the length */
            {
                return width + width + length + length;
            }
        }

    }

    /* Tests */
    [TestFixture]
    class RectangleAreaTest {
        [Test]
        public void testRectangleArea () {
            /* Given new rectangle with a width of 150 and a length of 50, compute the area */
            var rectangle = new Rectangle1 (150, 50);

            /* The area calculation of 150 and 50 should be 7500 */
            Assert.That (rectangle.computeArea, Is.EqualTo (7500));
        }

        class RectanglePerimeterTest {
            [Test]
            public void testRectanglePerimeter () {
                /* Given new rectangle with a width of 150 and a length of 50, compute the perimeter */
                var rectangle = new Rectangle1 (150, 50);

                /* The perimeter calculation of 150 and 50 should be 400 */
                Assert.That (rectangle.computePerimeter, Is.EqualTo (400));
            }

        }
        class SquareAreaTest {
            [Test]
            public void testSquareArea () {
                /* Given a new square with a width of 50 and a length of 50, compute the area */
                var square = new Square1 (50, 50);

                /* The area calculation of 50 and 50 should be 2500 */
                Assert.That (square.computeArea, Is.EqualTo (2500));
            }

            class SquarePerimeterTest {
                [Test]
                public void testSquarePerimeter () {
                    /* Given new square with a width of 50 and a length of 50, compute the perimeter */
                    var square = new Square1 (50, 50);

                    /* The perimeter calculation of 50 and 50 should be 200 */
                    Assert.That (square.computePerimeter, Is.EqualTo (200));
                }

            }

            class RectangleAreaExceptionTest {
                [Test]
                public void testRectangleAreaException () {
                    /* Given new rectangle with a width of 50 and a length of 50, compute the area */
                    var rectangle = new Rectangle1 (50, 50);

                    /* The area calcualtion of 50 and 50 should throw an exception */
                    var ex = Assert.Throws<System.ArgumentException> (() => rectangle.computeArea ());
                    Assert.That (ex.Message, Is.EqualTo ("Rectangle width and length values cannot match\r\nParameter name: rectangle.width and rectangle.length"));
                }

            }
            class RectanglePerimeterExceptionTest {
                [Test]
                public void testRectanglePerimeterException () {
                    /* Given new rectangle with a width of 50 and a length of 50, compute the perimeter */
                    var rectangle = new Rectangle1 (50, 50);

                    /* The perimeter calcualtion of 50 and 50 should throw an exception */
                    var ex = Assert.Throws<System.ArgumentException> (() => rectangle.computePerimeter ());
                    Assert.That (ex.Message, Is.EqualTo ("Rectangle width and length values cannot match\r\nParameter name: rectangle.width and rectangle.length"));
                }

            }

            class SquareAreaExceptionTest {
                [Test]
                public void testSquareAreaException () {
                    /* Given new square with a width of 51 and a length of 50, compute the area */
                    var square = new Square1 (51, 50);

                    /* The area calcualtion of 51 and 50 should throw an exception */
                    var ex = Assert.Throws<System.ArgumentException> (() => square.computeArea ());
                    Assert.That (ex.Message, Is.EqualTo ("Square width and length values must match\r\nParameter name: square.width and square.length"));
                }

            }
            class SquarePerimeterExceptionTest {
                [Test]
                public void testSquarePerimeterException () {
                    /* Given new square with a width of 51 and a length of 50, compute the perimeter */
                    var square = new Square1 (51, 50);

                    /* The perimeter calcualtion of 51 and 50 should throw an exception */
                    var ex = Assert.Throws<System.ArgumentException> (() => square.computePerimeter ());
                    Assert.That (ex.Message, Is.EqualTo ("Square width and length values must match\r\nParameter name: square.width and square.length"));
                }

            }

        }
    }

}