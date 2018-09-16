using System;
using NUnit.Framework;

namespace Project1
{
    class Rectangle1 
    {
        int width; 
        int height;
        int area;
        int perimeter;

        public Rectangle1(int inputWidth, int inputHeight)
        {
            width = inputWidth;
            height = inputHeight;
            computeArea();
            computePerimeter();
        } 
        public int computeArea()
        {
        return area = width * height;
        }
        public int computePerimeter()
        {
         return perimeter = width + width + height + height;
        }
   
    class Square1 : Rectangle1
    {
        public Square1(int inputWidth, int inputHeight) : base (inputWidth, inputHeight)
        {
            width = inputWidth;
            height = inputHeight; 
            computeArea();
            computePerimeter();
        }
    }   

[TestFixture]
class Test
{
       [TestCase]
       public void testSquare()
       {
        Square1 square = new Square1(50, 50);
        Assert.That(square.area, Is.EqualTo(2500));
        Assert.That(square.perimeter, Is.EqualTo(200));
       }
       [TestCase]
        public void testRectangle()
        {
        Rectangle1 rectangle = new Rectangle1(150, 50);
        Assert.That(rectangle.area, Is.EqualTo(7500));
        Assert.That(rectangle.perimeter, Is.EqualTo(400));
        }
}
    
    
   }

}
