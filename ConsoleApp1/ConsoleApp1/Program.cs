using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var screenNumber = 0.0;
            var returnValue = 0.0;
            var start = true;
            string entryOne = null;
            string entryTwo = null;
            double numberOne = 0.0;
            double numberTwo = 0.0;
            var aFunction = "0";
            while (true)
            {
                if (start == true)
                {
                    Console.WriteLine("Give me a number, Hal.");
                    entryOne = Console.ReadLine();
                    Console.WriteLine("Give me a simple arithmatic function: \"+\", \"-\", \"*\", \"/\"");
                    aFunction = Console.ReadLine();
                    start = false;
                    continue;
                }
                else
                {
                    Console.WriteLine("Give me a second number, Hal.");
                    entryTwo = Console.ReadLine();
                    numberOne = double.Parse(entryOne);
                    numberTwo = double.Parse(entryTwo);
                    if (aFunction == "+")
                    {
                        screenNumber = (numberOne + numberTwo);
                    }
                    else if (aFunction == "-")
                    {
                        screenNumber = (numberOne - numberTwo);
                    }
                    else if (aFunction == "*")
                    {
                        screenNumber = (numberOne * numberTwo);
                    }
                    else if (aFunction == "/")
                    {
                        screenNumber = (numberOne / numberTwo);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid arithmatic function.");
                        Console.ReadLine();
                    }

                    Console.WriteLine("The answer is " + screenNumber + ". You can continue to calculate by entering a new arithmatic function or type \"clear\" to start over.");
                    aFunction = Console.ReadLine();
                    if (aFunction == "quit")
                    {
                        break;
                    }
                    else if (aFunction == "clear")
                    {
                        screenNumber = 0.0;
                        start = true;
                        continue;
                    }
                    else
                    {
                        entryOne = screenNumber.ToString();
                        start = false;
                        continue;
                    }


                }

            }
        }
    }
}
