using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var screenNumber = 0.0;
            while (true)
            {
                Console.WriteLine("Give me a number, Hal.");
                var entryOne = Console.ReadLine();
                Console.WriteLine("Give me a simple arithmatic function: \"+\", \"-\", \"*\", \"/\"");
                var aFunction = Console.ReadLine();
                Console.WriteLine("Give me a second number, Hal.");
                var entryTwo = Console.ReadLine();
                var numberOne = double.Parse(entryOne);
                var numberTwo = double.Parse(entryTwo);
                if (aFunction == "+")
                {
                    screenNumber += (numberOne + numberTwo);
                    Console.WriteLine("The answer is " + screenNumber + ". You can continue to calculate by entering a new arithmatic function or type \"clear\" to start over.");
                    aFunction = Console.ReadLine();
                    if (aFunction == "quit")
                    {
                        break;
                    }
                    else if (aFunction == "clear")
                    {
                        screenNumber = 0.0;
                        continue;
                    }
                    else
                    {
                        continue;
                    }
                } else if (aFunction == "-")
                {
                    screenNumber += (numberOne - numberTwo);
                    Console.WriteLine("The answer is " + screenNumber + ". You can continue to calculate by entering a new arithmatic function or type \"clear\" to start over.");
                    aFunction = Console.ReadLine();
                    if (aFunction == "quit")
                    {
                        break;
                    }
                    else if (aFunction == "clear")
                    {
                        screenNumber = 0.0;
                        continue;
                    }
                    else
                    {
                        continue;
                    }
                } else if (aFunction == "*")
                {
                    screenNumber += (numberOne * numberTwo);
                    Console.WriteLine("The answer is " + screenNumber + ". You can continue to calculate by entering a new arithmatic function or type \"clear\" to start over.");
                    aFunction = Console.ReadLine();
                    if (aFunction == "quit")
                    {
                        break;
                    }
                    else if (aFunction == "clear")
                    {
                        screenNumber = 0.0;
                        continue;
                    }
                    else
                    {
                        continue;
                    }
                } else if (aFunction == "/")
                {
                    screenNumber += (numberOne / numberTwo);
                    Console.WriteLine("The answer is " + screenNumber + ". You can continue to calculate by entering a new arithmatic function or type \"clear\" to start over.");
                    aFunction = Console.ReadLine();
                    if (aFunction == "quit")
                    {
                        break;
                    } else if (aFunction == "clear")
                    {
                        screenNumber = 0.0;
                        continue;
                    } else
                    {
                        continue;
                    }
                } else

                {
                    Console.WriteLine("I'm working on this");
                }
            }

        }
    }
}