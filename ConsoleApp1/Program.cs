using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Carter
            string userName;
            string userAge;
            string currentYear;
            int birthYear;
            int userAgeInt;
            int currentYearInt;
            string integer1;
            string integer2;
            string integer3;
            int integer11;
            int integer21;
            int integer31;
            int integerTotal;
            string kmDistance1;
            string kmDistance2;
            string kmDistance3;
            double kmDistance11;
            double kmDistance21;
            double kmDistance31;
            double kmTotal;
            double kmAverage;
            string rightLeg;
            string leftLeg;
            double rightLegInt;
            double leftLegInt;
            double hypotenuseLength;
            Console.Write("Enter your name: ");
            userName = Console.ReadLine();
            Console.Write("Enter your age: ");
            userAge = Console.ReadLine();
            Console.Write("Enter the current year: ");
            currentYear = Console.ReadLine();
            userAgeInt = Convert.ToInt32(userAge);
            currentYearInt = Convert.ToInt32(currentYear);
            birthYear = (currentYearInt - userAgeInt);
            Console.WriteLine($"Your name is {userName}, and you were born in {birthYear}");
            Console.Write("Enter a number: ");
            integer1 = Console.ReadLine();
            Console.Write("Enter another number: ");
            integer2 = Console.ReadLine();
            Console.Write("Enter one final number: ");
            integer3 = Console.ReadLine();
            integer11 = Convert.ToInt32(integer1);
            integer21 = Convert.ToInt32(integer2);
            integer31 = Convert.ToInt32(integer3);
            integerTotal = (integer11 + integer21 + integer31);
            Console.WriteLine($"The total of your 3 numbers added together is {integerTotal}");
            Console.Write("Enter a distance in kilometers: ");
            kmDistance1 = Console.ReadLine();
            Console.Write("Enter another distance: ");
            kmDistance2 = Console.ReadLine();
            Console.Write("Enter one final distance: ");
            kmDistance3 = Console.ReadLine();
            kmDistance11 = Convert.ToDouble(kmDistance1);
            kmDistance21 = Convert.ToDouble(kmDistance2);
            kmDistance31 = Convert.ToDouble(kmDistance3);
            kmTotal = (kmDistance11 + kmDistance21 + kmDistance31);
            kmAverage = Math.Round(kmTotal / 3, 2);
            Console.WriteLine($"The average distance for the 3 entered is {kmAverage}");
            Console.Write("Enter the length of one leg: ");
            rightLeg = Console.ReadLine();
            Console.Write("Enter the length of the other leg: ");
            leftLeg = Console.ReadLine();
            rightLegInt = Convert.ToDouble(rightLeg);
            leftLegInt = Convert.ToDouble(leftLeg);
            hypotenuseLength = Math.Sqrt((rightLegInt * rightLegInt) + (leftLegInt * leftLegInt));
            Console.WriteLine($"The hypotenuse of the triangle is {hypotenuseLength}");
        }
    }
}
