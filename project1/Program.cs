using System;

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
        
        computeArea();
        computePerimeter();
        }
    }   


    static void Test ( string[ ] args )
    {
       //* test square */
        Square1 square = new Square1(50, 50);
        Console.WriteLine ("The area of the square is {0}", square.computeArea());
        Console.WriteLine ("The perimater of the square is {0}", square.computePerimeter());

        //* test rectangle */
        Rectangle1 rectangle = new Rectangle1(150, 50);
        Console.WriteLine ("The area of the rectangle is {0}", rectangle.computeArea());
        Console.WriteLine ("The perimater of the rectangle is {0}", rectangle.computePerimeter());
        

         
    
    }
   }

}
