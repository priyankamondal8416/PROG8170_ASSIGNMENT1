using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8170_ASSIGNMENT1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rectangleChoice = CheckRectangleOption();
            GetRectangleDetails(rectangleChoice);
        }

        public static int ValidateMenuSelection()
        {
            string userInput = "";
            bool validMenuSelect = false;
            int choice = 0;

            while (!validMenuSelect)
            {
                Console.WriteLine("============================================");
                Console.WriteLine("Press 1 to Get Rectangle Length");
                Console.WriteLine("Press 2 to Change Rectangle Length");
                Console.WriteLine("Press 3 to Get Rectangle Width");
                Console.WriteLine("Press 4 to Change Rectangle Width");
                Console.WriteLine("Press 5 to Get Rectangle Perimeter");
                Console.WriteLine("Press 6 to Get Rectangle Area");
                Console.WriteLine("Press 7 to Exit");
                Console.WriteLine("============================================");
                Console.WriteLine("Please select an option, by entering a number:");
                userInput = Console.ReadLine();
                Console.WriteLine("============================================");

                if (string.IsNullOrWhiteSpace(userInput) || !int.TryParse(userInput, out choice) || (choice <= 0 || choice >= 8))
                {
                    Console.WriteLine("*!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!*");
                    Console.WriteLine("     That's not a valid menu option, please try again.");
                    Console.WriteLine("*!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!*");
                }
                else { validMenuSelect = true; }
            }

            Console.WriteLine();
            return choice;
        }

        public static int ValidateUserInput(string rectSide)
        {
            bool isValid = false;
            int number = 1;

            while (!isValid)
            {
                Console.WriteLine($"Please enter the {rectSide} of your rectangle:");
                string userInput = Console.ReadLine();

                bool input = int.TryParse(userInput, out number);

                if (!input)
                {
                    Console.WriteLine("*!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!*");
                    Console.WriteLine("     That's not a valid input, please try again.");
                    Console.WriteLine("*!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!*");
                }
                else if (number <= 0)
                {
                    Console.WriteLine("*!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!*");
                    Console.WriteLine("     Number cannot be less than 0. Please try again.");
                    Console.WriteLine("*!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!*");
                }
                else
                {
                    isValid = true;
                }
            }

            return number;

        }


        public static int CheckRectangleOption()
        {
            bool isValid = false;
            int choice = 1;

            while (!isValid)
            {
                Console.WriteLine("\n***********************************************************");
                Console.WriteLine($"Press 1 to Create default (1 unit X 1 unit) Rectangle");
                Console.WriteLine($"Press 2 to Create custom Rectangle.");
                Console.WriteLine("\n***********************************************************");
                Console.WriteLine("\nPlease select an option, by entering a number:");
                string userInput = Console.ReadLine();

                bool input = int.TryParse(userInput, out choice);

                if (!input)
                {
                    Console.WriteLine("*!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!*");
                    Console.WriteLine("     That's not a valid inlut, please try again.");
                    Console.WriteLine("*!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!*");
                }
                else if (choice <= 0 || choice >= 3)
                {
                    Console.WriteLine("*!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!*");
                    Console.WriteLine("     That's not a valid input, please try again");
                    Console.WriteLine("*!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!**!*!*");
                }
                else
                {
                    isValid = true;
                }
            }

            return choice;

        }

        public static void GetRectangleDetails(int rectangleChoice)
        {
            Rectangle rectangle = new Rectangle();

            int userMenuChoice = 0;

            int length = 1;
            int width = 1;

            if (rectangleChoice == 2)
            {
                length = ValidateUserInput("Lenght");
                width = ValidateUserInput("Width");
                rectangle = new Rectangle(length, width);
                Console.WriteLine($"Your Rectangle is {length} X {width} unit(s).\n");
            }

            do
            {
                userMenuChoice = ValidateMenuSelection();

                if (userMenuChoice > 0)
                {
                    switch (userMenuChoice)
                    {
                        // Get Length
                        case 1:
                            Console.WriteLine($"Your Rectangle Length is {rectangle.GetLength()} unit(s)\n");
                            break;
                        // Set Length
                        case 2:
                            length = ValidateUserInput("Lenght");
                            Console.WriteLine($"Your Rectangle Length is now {length} unit(s)\n");
                            rectangle = new Rectangle(length, width);
                            break;
                        // Get Width
                        case 3:
                            Console.WriteLine($"Your Rectangle Width is {rectangle.GetWidth()} unit(s)\n");
                            break;
                        // Set Width
                        case 4:
                            width = ValidateUserInput("Width");
                            Console.WriteLine($"Your Rectangle Width is now {width} unit(s)\n");
                            rectangle = new Rectangle(length, width);
                            break;
                        // Get Perimeter
                        case 5:
                            int perimeter = rectangle.GetPerimeter();
                            Console.WriteLine($"Your Rectangle's Perimeter is {perimeter} unit(s)\n");
                            break;
                        // Get Area
                        case 6:
                            int area = rectangle.GetArea();
                            Console.WriteLine($"Your Rectangle's Area is {area} unit(s)\n");
                            break;
                        case 7:
                            break;
                        default:
                            break;
                    }
                }
            } while (userMenuChoice != 7);

        }
    }
}
