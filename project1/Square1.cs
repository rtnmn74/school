using System;

namespace Project1
{
    class Square1    {
        public static void Main(string[] args)
        {
            string userInputWidth;
            string userInputHeight;
            int width;
            int height;
            int perimeter;
            int area;

            /*Take user input for width */
            Console.Write("Enter Width: ");
            userInputWidth = Console.ReadLine();
            /*Convert user input string to integer for calculating */
            width = Convert.ToInt32(userInputWidth);
            /*Output user input for width */
            Console.WriteLine("You Entered {0}", width); 

           /*Take user input for height */
            Console.Write("Enter Height: ");
            userInputHeight = Console.ReadLine();
            /*Convert user input strings to integers for calculating */
            height = Convert.ToInt32(userInputHeight);
            /*Output user input height*/
            Console.WriteLine("You entered {0}", height);

            /*Calculate the perimeter of the height and width inputs */
            perimeter = width + width + height + height;

            /*Calculate the area of the inputs  */
            If height = width then
            area = height * height
            else null;

            /* Output the perimeter of the shape based on the inputs */
            Console.WriteLine("The perimeter is {0}", perimeter);
        }
    }
}
