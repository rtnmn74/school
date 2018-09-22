using System;
using NUnit.Framework;

namespace Project1 {
    /* Class for Rectangle1 */
    class Rectangle1 {
      
        protected int width;
        protected int length;

        /*Parameters  */
        public virtual int Width { get => width; set => width = value; }
        public virtual int Length { get => length; set => length = value; }

        /* Routine that computes the area  */
        public int computeArea () 
        {
            /* Return the area  by multiplying the width x the length */
            {
                return Width * Length;
            }
        }

        /* Routine that computes the perimeter */
        public int computePerimeter () 
        {
                /* Return the perimeter by adding 2 times the width with 2 times the length  */
                return Width + Width + Length + Length;
            }
        }

    /* Subclass for Square1 */
    class Square1 : Rectangle1{


      
        public override int Width 
        {
            /* Get width value from rectangle class */ 
            get {return base.Width;}
            /* Set width value from setSides routine */
            set {SetSides(value);}
        }

        public override int Length
        {
            /* Get length value from rectangle class */ 
            get {return base.Length;}
            /* Set length value from setSides routine   */
            set {SetSides(value);}
        }
      

        /* Routine to default value for all sides based on second last value input*/
        private void SetSides(int value)
        {
           base.Width = value;
           base.Length = value; 
        }

       }

    /* Tests */
    [TestFixture]
    class RectangleAreaTest {
        [Test]
        public void testRectangleArea () {
            /* Given new rectangle with a width of 150 and a length of 50, compute the area */
            var rectangle = new Rectangle1();
            rectangle.Width = 150;
            rectangle.Length = 50;
            var result = rectangle.computeArea();
            /* The area calculation should be 7500 */
            Assert.That (result, Is.EqualTo (7500));
        }

        class RectanglePerimeterTest {
            [Test]
            public void testRectanglePerimeter () {
                /* Given new rectangle with a width of 150 and a length of 50, compute the perimeter */
                var rectangle = new Rectangle1();
                rectangle.Width = 150;
                rectangle.Length = 50;
                var result = rectangle.computePerimeter();

                /* The perimeter calculation should be 400 */
                Assert.That (result, Is.EqualTo (400));
            }

        }
        class SquareAreaTest {
            [Test]
            public void testSquareArea () {
                /* Given a new square with a width of 50 and a length of 50, compute the area */
                var square = new Square1();
                square.Width = 50;
                square.Length = 50;
                var result = square.computeArea();

                /* The area calculation should be 2500 */
                Assert.That (result, Is.EqualTo (2500));
            }
        }

            class SquarePerimeterTest {
                [Test]
                public void testSquarePerimeter () {
                    /* Given new square with a width of 50 and a length of 50, compute the perimeter */
                    var square = new Square1();
                    square.Width = 50;
                    square.Length = 50;
                    var result = square.computePerimeter();

                    /* The perimeter calculation should be 200 */
                    Assert.That (result, Is.EqualTo (200));
                }

            }

            class SquareAreaValueNotEqualTest {
            [Test]
            public void testSquareArea () {
                /* Given a new square with a width of 51 and a length of 50, compute the area using second input value as default*/
                var square = new Square1();
                square.Width = 51;
                square.Length = 50;
                var result = square.computeArea();

                /* The area calculation should be 2500 */
                Assert.That (result, Is.EqualTo (2500));
            }
        }

            class SquarePerimeterValueNotEqualTest {
                [Test]
                public void testSquarePerimeter () {
                    /* Given new square with a width of 50 and a length of 51, compute the perimeter using second input value as default value*/
                    var square = new Square1();
                    square.Width = 50;
                    square.Length = 51;
                    var result = square.computePerimeter();

                    /* The perimeter calculation should be 204 */
                    Assert.That (result, Is.EqualTo (204));
                }

            }
            

            

    }

}