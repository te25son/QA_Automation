using System;

namespace examples
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("-- EXAMPLE 1 --");
            ExampleOne.CheckNumberIsValid();

            Console.WriteLine("\n-- EXAMPLE 2 --");
            ExampleTwo.GetMaxInputValue();

            Console.WriteLine("\n-- EXAMPLE 3 --");
            ExampleThree.DimensionsAreLandscapeOrPortrait();

            Console.WriteLine("\n-- EXAMPLE 4 --");
        }
    }

    class ExampleOne
    {
        public static void CheckNumberIsValid()
        {
            Console.WriteLine("Enter a number: ");
            var userInput = Console.ReadLine();
            
            int userInputNumber;
            
            if (int.TryParse(userInput, out userInputNumber))
            {
                if (userInputNumber >= 1 && userInputNumber <= 10)
                {
                    Console.WriteLine("Valid.");
                }
                else
                {
                    Console.WriteLine("Invalid.");
                }
            }
            else
            {
                Console.WriteLine("Input value given was not a number.");
                CheckNumberIsValid();
            }
        }
    }

    class ExampleTwo
    {
        public static void GetMaxInputValue()
        {
            Console.WriteLine("Enter a number: ");
            var firstNumberInput = Console.ReadLine();

            Console.WriteLine("Enter a second number: ");
            var secondNumberInput = Console.ReadLine();
            
            int firstNumber, secondNumber;
            var firstNumberIsInteger = int.TryParse(firstNumberInput, out firstNumber);
            var secondNumberIsInteger = int.TryParse(secondNumberInput, out secondNumber);

            if (firstNumberIsInteger && secondNumberIsInteger)
            {
                var maxValue = Math.Max(firstNumber, secondNumber);
                Console.WriteLine($"The max value is {maxValue}");
            }
            else
            {
                Console.WriteLine("One or both of the input values given was not a number.");
                GetMaxInputValue();
            }
        }
    }

    class ExampleThree
    {
        public static void DimensionsAreLandscapeOrPortrait()
        {
            Console.WriteLine("Enter the image's height: ");
            var heightInput = Console.ReadLine();

            Console.WriteLine("Enter the image's length: ");
            var lengthInput = Console.ReadLine();

            int height, length;
            var heightIsInteger = int.TryParse(heightInput, out height);
            var lengthIsInteger = int.TryParse(lengthInput, out length);

            if (heightIsInteger && lengthIsInteger)
            {
                if (height == length)
                {
                    Console.WriteLine("The image is a square.");
                }
                else
                {
                    var maxValue = Math.Max(height, length);

                    if (maxValue == height)
                    {
                        Console.WriteLine("The image's orientaton is portrait.");
                    }
                    else
                    {
                        Console.WriteLine("The image's orientaton is landscape.");
                    }
                }
            }
            else
            {
                Console.WriteLine("One or both of the input values given was not a number.");
                DimensionsAreLandscapeOrPortrait();
            }
        }
    }
}
