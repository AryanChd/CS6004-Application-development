//WORKSHOP 2 

//VARIABLES AND DATA TYPES

//Task 1: Write a C# program that performs the following: [ 5 Minutes]
//Declare a variable named userName to store your name and initialize it.
//Declare a variable named luckyNumber to store an integer and initialize it to your favorite single-digit number.
//Use string interpolation to print a single line of output to the console that says: "Hello, [userName]! Your lucky number is [luckyNumber] ."

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Numerics;
using System.Xml.Linq;
using workshop2;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace workshop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string UserName = "Aryan";
            int luckyNumber = 7;
            Console.WriteLine($"Hello, {UserName}! Your lucky number is {luckyNumber}.");

        }
    }
}

//Task 2: Constants[5 Minutes]
//Create a class named Circle.
//Inside the class, declare a constant variable named PI and initialize it with the value 3.14.
//In the Main() method of Program.cs,
//Try to modify the value of PI of the Circle class and observe the compilation error and explain the error. 
//Additionally, you can create methods to calculate area and perimeter of the circle.


namespace workshop2
{
    internal class Circle
    {
        public const double PI = 3.14;
        static void Main(string[] args)
        {
            double radius = 5;
            double area = PI * radius * radius;
            double perimeter = 2 * PI * radius;

            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimeter: {perimeter}");
        }

    }
}

//Task 3: Data Types and Type Conversion [5 minutes]
//Declare and initialize variables of the following types: byte, short, int, long, float, double, decimal, char, bool.
//Convert the integer value 42 to a string and store it in a new variable.
//Convert a string "3.14" to a double and store it in a new variable.
//Print all variables to the console with appropriate labels showing their types and values.

using System;

namespace workshop2
{
    internal class DataTypesDemo
    {
        static void Main(string[] args)
        {

            byte byteVlue = 255;
            short shortVlue = -32678;
            int intVlue = 42;
            long longVlue = 9558432155L;
            float floatVlue = 3.14F;
            double doubleVlue = 9.81;
            decimal decimalVlue = 19.99M;
            char charVlue = 'A';
            bool boolVlue = true;

            string stringFromInt = intVlue.ToString();

            string strNumber = "3.14";
            double convertedDouble = Convert.ToDouble(strNumber);

            Console.WriteLine($"byte: {byteVlue}");
            Console.WriteLine($"short: {shortVlue}");
            Console.WriteLine($"int: {intVlue}");
            Console.WriteLine($"long: {longVlue}");
            Console.WriteLine($"float: {floatVlue}");
            Console.WriteLine($"double: {doubleVlue}");
            Console.WriteLine($"decimal: {decimalVlue}");
            Console.WriteLine($"char: {charVlue}");
            Console.WriteLine($"bool: {boolVlue}");
            Console.WriteLine($"Integer 42 converted to string: \"{stringFromInt}\"");
            Console.WriteLine($"String \"3.14\" converted to double: {convertedDouble}");
        }
    }
}


//Task 5: Date Time and Time Span [10 minutes]
//Creates a DateTime variable representing your birthdate.
//Creates another DateTime variable representing the current date and time.
//Calculates your age using TimeSpan (you'll need to subtract the two DateTime values).
//Prints your birthdate, the current date, and your age in years.
//Adds 10 days to your birthdate and prints the resulting date.

using System;

namespace Workshop2
{
    class Program
    {
        static void Main()
        {
            DateTime birthDate = new DateTime(2006, 03, 31);
            DateTime today = DateTime.Today;

            if (birthDate > today)
            {
                Console.WriteLine("Error: Birthdate is in the future. Please correct it.");
                return;
            }

            var age = today - birthDate;
            int years = (int)(age.Days / 365.25);
            int months = (int)((age.Days % 365.25) / 30.44);
            int days = (int)((age.Days % 365.25) % 30.44);

            Console.WriteLine($"Birthdate: {birthDate:d}");
            Console.WriteLine($"Today:     {today:d}");
            Console.WriteLine($"Age:       {years} years, {months} months, {days} days");
            Console.WriteLine($"Birthdate + 10 days: {birthDate.AddDays(10):d}");
        }
    }
}

//Task 4: Array and Array Methods [10 minutes]
//Creates a single-dimensional integer array containing 5 of your favorite numbers.
//Uses Array.Sort() to sort the array in ascending order.
//Uses Array.Reverse() to reverse the sorted array.
//Prints each element of the array using a for loop.
//Uses Array.IndexOf() to find the position of a specific number in the array.


using System;

namespace Workshop2
{
    class Program
{
    static void Main()
    {

        int[] favoriteNumbers = { 7, 77, 8, 17, 69 };

        Console.WriteLine("Original Array:");
        PrintArray(favoriteNumbers);

        Array.Sort(favoriteNumbers);
        Console.WriteLine("\nSorted Array (Ascending):");
        PrintArray(favoriteNumbers);

        Array.Reverse(favoriteNumbers);
        Console.WriteLine("\nReversed Array (Descending):");
        PrintArray(favoriteNumbers);

        int searchNumber = 8;
        int index = Array.IndexOf(favoriteNumbers, searchNumber);
        Console.WriteLine($"\nNumber {searchNumber} is at index: {index}");
    }
    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
}


//Task 5: Generic Collections (List and Dictionary) [10 minutes]
//Creates a List<string> containing the names of 3 of your favorite fruits.
//Adds a new fruit to the list.
//Removes one fruit from the list.
//Prints all fruits in the list using a foreach loop.
//Creates a Dictionary<int, string> where keys are fruit IDs (1,2,3) and values are the fruit names.
//Adds a new entry to the dictionary and prints all key-value pairs.


using System;
using System.Collections.Generic;

namespace Workshop2
{
    class Program
    {
        static void Main()
        {
            List<string> fruits = new List<string> { "Apple", "Mango", "Banana" };

            fruits.Add("Orange");

            fruits.Remove("Mango");

            Console.WriteLine("Fruits in the list:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Dictionary<int, string> fruitDict = new Dictionary<int, string>
            {
                { 1, "Apple" },
                { 2, "Banana" },
                { 3, "Orange" }
            };

            fruitDict.Add(4, "Grapes");

            Console.WriteLine("\nFruit Dictionary:");
            foreach (var item in fruitDict)
            {
                Console.WriteLine($"ID: {item.Key}, Fruit: {item.Value}");
            }
        }
    }
}


