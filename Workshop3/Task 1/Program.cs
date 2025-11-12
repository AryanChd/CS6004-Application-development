using System;

namespace workshop3
{
    class Program
    {
        static void Main(string[] args)
        {
            Operators op = new Operators();

            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Call all arithmetic methods
            op.Add(num1, num2);
            op.Subtract(num1, num2);
            op.Multiply(num1, num2);
            op.Divide(num1, num2);

            // Odd or even check
            Console.Write("\nEnter a number to check if it's odd or even: ");
            int number = Convert.ToInt32(Console.ReadLine());
            op.OddEvenFinder(number);

            Console.ReadLine(); // Keeps console window open
        }
    }
}
