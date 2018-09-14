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

            /*Take user input for shape width */
            Console.Write("Enter Width: ");
            userInputWidth = Console.ReadLine(); 

           /*Take user inpout for shape lendth */
            Console.Write("Enter Length: ");
            userInputLength = Console.ReadLine();

            /*Convert user input strings to integers for calculating */
            width = Convert.ToInt32(userInputWidth);
            length = Convert.ToInt32(userInputLength);

            /*Calculate the perimeter of the shape length and width inputs */
            perimeter = width + width + length + length;
            
            /* Output the perimeter of the shape based on the inputs */
            Console.WriteLine("The perimeter is {0}", perimeter);
        }
    }
}
