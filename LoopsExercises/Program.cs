using System;
using System.Dynamic;

namespace LoopsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepThinking = true;
            while (keepThinking)
            {
                Console.Clear();
                Console.WriteLine("LOOPING EXERCISES\n");
                Console.WriteLine("Which exercise would you like to run?");
                Console.WriteLine("1. Print Numbers in Reverse Order");
                Console.WriteLine("2. Reverse Counting");
                Console.WriteLine("3. Print the Square of Even Numbers");
                Console.WriteLine("4. Guess the Magic Number");
                Console.WriteLine("Press Q to quit");

                string userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "1":
                        NumbersInReverse();
                        break;
                    case "2":
                        ReverseCounting();
                        break;
                    case "3":
                        SquareOfEvenNumbers();
                        break;
                    case "4":
                        GuessMagicNumber();
                        break;
                    case "q":
                        keepThinking = false;
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        break;
                }
            }
        }

        static void NumbersInReverse()
        {
            // Print out numbers from 5 to 1.

            Console.Clear();
            Console.WriteLine("PRINT NUMBERS IN REVERSE ORDER\n");

            // Enter your solution here
            for (int count = 5; count > 0; count--)
            {
                Console.WriteLine(count + " ");
            }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }


        static void ReverseCounting()
        {
            // Ask the user for a number between 1-20. Starting at the number given,
            // count backwards to 1 and print the numbers to the console.

            Console.Clear();
            Console.WriteLine("REVERSE COUNTING\n");

            // Enter your solution here
            Console.WriteLine("Please enter number between 1-20");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            for (; userNumber > 0; userNumber--)
            {
                Console.WriteLine(userNumber + " ");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void SquareOfEvenNumbers()
        {
            // Print the squares (the number multipied by itself) for even numbers between 1-9.

            Console.Clear();
            Console.WriteLine("PRINT THE SQUARE OF EVEN NUMBERS\n");

            // Enter your solution here
            for (int num = 2; num > 0 & num <= 9; num = num + 2)
            {
                Console.WriteLine((num * num) + "");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void GuessMagicNumber()
        {
            // Write a console application that asks the user for an integer.
            // If that integer is evenly divisible by 3, then print “You Won!”.
            // If it isn’t, ask the user to “Try again.”
            // Keep asking them for a number (looping) until they win.

            Console.Clear();
            Console.WriteLine("GUESS THE MAGIC NUMBER\n");

            // Enter your solution here

            Console.WriteLine("Guess the magic number... Pick a number!");

            bool notGuessed = false;

            while (notGuessed == false)
            {
            int guess = Convert.ToInt32(Console.ReadLine());
                if (guess % 3 == 0)
                {
                    Console.WriteLine("You Won!");
                    notGuessed = true;
                }
                else
                {
                    Console.WriteLine("Try Again!");
                }

            }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        

    }
}







