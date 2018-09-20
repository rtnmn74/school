using System;
using NUnit.Framework;

namespace Project1
{
    class Rectangle1 
    {
        /* Properties for rectangle*/
        protected int Width {get; set; } 
        protected int Length {get; set; }
        
        /* Contructor for a rectangle */
        public Rectangle1(int width, int length)
        {
            this.Width = width;
            this.Length = length;

           /* if (width != length)
            {
            throw new ArgumentException ("Width and length should not match. Please re-enter width and length.");    
            }
            else
            { 
            /* Call computeArea routine */
            /* computeArea(width, length);
            /* Call computePerimeter routine */
            /* computePerimeter(width, length);
            }
            */
        }

        /* Routing that computes the area of a shape with 4 sides */
        public int computeArea()
        {
        /* Return area of a shape with 4 sides by multiplying the width x length */
        return this.Width * this.Length;
        }

        /* Routine that computes the perimeter of a shape with 4 sides */
        public int computePerimeter()
        {
         /* Return the perimeter of a shape with 4 sides by adding the value of all sides */
         return this.Width + this.Width + this.Length + this.Length;
        }



    class Square1 : Rectangle1
    {
        
        public Square1() { }

        /* Contructor for a square */
        public Square1(int width, int length)
        {
            this.Width = width ;
            this.Length = bot;


            if (leftSide == bottomSide) 
            {
            /* Call computeArea routine */
            computeArea(leftSide, bottomSide);
            /* Call computePerimeter routine */
            computePerimeter(leftSide, bottomSide);
            } else
            {
             Console.WriteLine ("Left side and the bottomSide should match. Please re-enter width and length.");   
            }
        }
    }   

[TestFixture]
class RectangleAreaTest
    {
        [Test]
        public void testRectangleArea()
        {
        /* Given new rectangle compute the area */
        var rectangle = new Rectangle1();

        /* Compute the area of 150 and 50 */
        var returnValue = rectangle.computeArea(150,50);

        /* The area of 150 and 50 should be 7500 */
        Assert.That(returnValue, Is.EqualTo(7500));
        }

class RectanglePerimeterTest
    {
        [Test]
        public void testRectanglePerimeter()
        {
        /* Given new rectangle compute the perimeter */
        var rectangle = new Rectangle1();

        /* Compute the perimter of 150 and 50 */
        var returnValue = rectangle.computePerimeter(150,50);

        /* The perimeter of 150 and 50 should be 400 */
        Assert.That(returnValue, Is.EqualTo(400));
        }

     }
class SquareAreaTest
    {
        [Test]
        public void testSquareArea()
        {
        /* Given new square compute the area */
        var square = new Square1();

        /* Compute the area of 50 and 50 */
        var returnValue = square.computeArea(51,50);

        /* The area of 50 and 50 should be 2000 */
        Assert.That(returnValue, Is.EqualTo(2500));
        }

class SquarePerimeterTest
    {
        [Test]
        public void testSquarePerimeter()
        {
        /* Given new square compute the perimeter */
        var square = new Square1();

        /* Compute the perimter of 50 and 50 */
        var returnValue = square.computePerimeter(50,50);

        /* The perimeter of 50 and 50 should be 200 */
        Assert.That(returnValue, Is.EqualTo(200));
        }

    }


    }
    }
    
    }

}
