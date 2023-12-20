namespace UserInput
{
    public class UserInput
    {
        public void start()
        {
            Console.WriteLine("Welcome to the Circle Calculator!");
            Console.WriteLine("This program will calculate the area, circumference, diameter, perimeter and radius of a circle.");
            Console.WriteLine();
            Console.WriteLine();
        }

        public void close()
        {
            //Wait for user input before closing
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Thank you for using the Circle Calculator!");
            Console.WriteLine("Press any key to close the program...");
            Console.ReadKey();
        }

        public bool continuePrompt()
        {
            Console.WriteLine("Would you like to calculate another circle? (y/n)");
            string? input = Console.ReadLine();
            // Clears the console
            if (input == "y")
            {
                Console.Clear();
                return true;
            }
            else
            {
                return false;
            }
        }

        //Prompt User wich method they would like to use
        public int getMethod()
        {
            Console.WriteLine("How would you like to calculate the circle? Via the radius, diameter, area or perimeter?");
            Console.WriteLine("1. Radius");
            Console.WriteLine("2. Diameter");
            Console.WriteLine("3. Area");
            Console.WriteLine("4. Perimeter");
            int input = Convert.ToInt32(Console.ReadLine());
            if(input == 1 || input == 2 || input == 3 || input == 4)
            {
                return input;
            } else
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Please try again.");
                return getMethod();
            }
        }

        public int getRadius()
        {
            Console.WriteLine("Enter the radius of the circle:");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int radius))
            {
                return radius;
            }
            else
            {
                invalidInput();
                return getRadius();
            }
        }

        public int getDiameter()
        {
            Console.WriteLine("Enter the diameter of the circle:");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int diameter))
            {
                return diameter;
            }
            else
            {
                invalidInput();
                return getDiameter();
            }
        }

        public int getPerimeter()
        {
            Console.WriteLine("Enter the perimeter of the circle:");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int perimeter))
            {
                return perimeter;
            }
            else
            {
                invalidInput();
                return getPerimeter();
            }
        }

        public int getArea()
        {
            Console.WriteLine("Enter the area of the circle:");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int area))
            {
                return area;
            }
            else
            {
                invalidInput();
                return getArea();
            }
        }

        //handle invalid input
        public void invalidInput()
        {
            Console.Clear();
            Console.WriteLine("Invalid input. Please try again.");
        }

    }
}