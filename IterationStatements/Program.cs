using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()

        public static void PrintNumbers1000()
        {
            for (int i = 1000; i >= -1000;i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void UppbyThree()
        {
            for (int i = 0; i < +999; i += 3)
            {
                Console.WriteLine(i);
            }

        }
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.

        public static void EqualorNotEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} and{num2} are the same, so true!");
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are not equal, so false!");
            }

        }





        // 4. Write a method that che cks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.

        public static void EvenOrOdd(int number)

        {
            if ((number % 2 == 0))
            {
                Console.WriteLine($"the number is even,");
            }
            else
            {
                Console.WriteLine($"the number is odd"); 
            }

        }

        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.

        public static void PosOrNeg(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"Number is positive");
            }

            else if (number < 0)
                    {
                Console.WriteLine($"Number is negative");
                    }

            if (number == 0)
            { 
            Console.WriteLine ($"0 is neutral");
            }
        }


        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.

        public static void CanVote()
        {
            Console.WriteLine("Enter your age!");
            var canParse = int.TryParse( Console.ReadLine(), out var num);

            while (canParse == false)
            { 
            Console.WriteLine("Try again, please enter a valid age");
                canParse= int.TryParse ( Console.ReadLine(), out num);
            }

            if (num >= 18) 
            { Console.WriteLine($"Congrats, at {num}! You can vote!"); 
            } 
            else if (num < 18)
            { 
                Console.WriteLine("Sorry, not old enough to vote.");
            }



        }

        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.

        public static void TenRange()
        {
            Console.WriteLine("Please give me number");
            var canParse = int.TryParse ( Console.ReadLine(), out int userNumber);

            while (!canParse)
            {
                Console.WriteLine("invalid, try again"); 
                canParse = int.TryParse ( Console.ReadLine(),out userNumber);
            }
            if (userNumber <= 10 && userNumber >= -10)
            {
                Console.WriteLine($"congrats, {userNumber} fits in Ten Range"); 
            } 
            
            else
            {
                Console.WriteLine($"{userNumber} is not in the the Ten Range");
            } 


        }


        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"



        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.
        // 

        public static void MultiplyThroughTweleve(int number)

        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} * {number} = {i * number} "); 
            }
        }
        static void Main(string[] args)
        {
            //PrintNumbers1000();
            //UppbyThree();
            //EqualorNotEqual(0, 1);
            //EvenOrOdd(number: 2); 
            //PosOrNeg(number: 3);
            //CanVote(); 
            TenRange();
            MultiplyThroughTweleve(3); 
        }
    }
}
