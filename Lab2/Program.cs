using System;

namespace Lab_2
{
    class Program
    {
        static void Main()
        {
            //input variables
            float length;
            float width;
            float height;

            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            //asking for input numbers and storing them in their variables
            Console.Write("Enter length in decimal feet: ");
            length = float.Parse(Console.ReadLine());
            Console.Write("Enter width in decimal feet: ");
            width = float.Parse(Console.ReadLine());
            Console.Write("Enter height in decimal feet: ");
            height = float.Parse(Console.ReadLine());

            //processing the input variables into the output variables
            float area = length * width;
            float perimeter = length * 2 + width * 2;
            float volume = length * width * height;

            //telling the users the results
            Console.WriteLine($"Area: {area}square feet");
            Console.WriteLine($"Perimeter: {perimeter}feet");
            Console.WriteLine($"Volume: {volume}feet cube");

            Continue();
        }

        static void Continue()
        {
            //asking the user if they would like to continue the program
            Console.Write("Continue? (y/n): ");
            if (Console.ReadLine().ToLower() == "y")
            {
                //if yes, restart at main
                Main();
            }
            else
            {
                //if no, exit
                return;
            }
        }
    }
}