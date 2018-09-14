using System;

namespace Project1
{
    class Shape
    {
        public static void Main(string[] args)
        {
            string userInputWidth;
            string userInputLength;
            int width;
            int length;
            int perimeter;


            Console.Write("Enter Width: ");
            userInputWidth = Console.ReadLine(); 
           
            Console.Write("Enter Length: ");
            userInputLength = Console.ReadLine();

            width = Convert.ToInt32(userInputWidth);
            length = Convert.ToInt32(userInputLength);
            perimeter = width + width + length + length;
         
            Console.Write("The perimeter is {0}", perimeter);
        }
    }
}
