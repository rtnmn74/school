using System;

namespace Project1
{
    class Square1    {
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
            /*Convert user input string to integer for calculating */
            width = Convert.ToInt32(userInputWidth);
            /*Output user input for width */
            Console.WriteLine("You Entered {0}", width); 

           /*Take user inpout for shape length */
            Console.Write("Enter Length: ");
            userInputLength = Console.ReadLine();
            /*Convert user input strings to integers for calculating */
            length = Convert.ToInt32(userInputLength);
            /*Output user input length*/
            Console.WriteLine("You entered {0}", length);

            /*Calculate the perimeter of the shape length and width inputs */
            perimeter = width + width + length + length;
            
            /* Output the perimeter of the shape based on the inputs */
            Console.WriteLine("The perimeter is {0}", perimeter);
        }
    }
}
