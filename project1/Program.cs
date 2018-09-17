using System;
using NUnit.Framework;

namespace Project1
{
    class Rectangle1 
    {
        int width; 
        int height;

        public int computeArea(int width, int height)
        {
        return width * height;
        }
        public int computePerimeter(int width, int height)
        {
         return width + width + height + height;
        }
        public Rectangle1()
        {
            computeArea(width, height);
            computePerimeter(width, height);
        }
   
    class Square1 : Rectangle1
    {
        public Square1()
        {
            computeArea(width, height);
            computePerimeter(width, height);
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
        var returnValue = square.computeArea(50,50);

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
