using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("---------------------------");
                Console.WriteLine("     Basic Calculator ");
                Console.WriteLine("---------------------------");


                Console.WriteLine("\nEnter First Number: ");
                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }

                Console.WriteLine("Enter Second Number: ");
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }

                Console.WriteLine("Enter the operation to be carried out: ");
                Console.WriteLine("     +       To Add");
                Console.WriteLine("     -       To Subtract");
                Console.WriteLine("     *       To Multiply");
                Console.WriteLine("     /       To Divide");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"The answer is  = {result}");
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"The answer is  = {result}");
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"The answer is = {result}");
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = (double)num1 / num2;
                            Console.WriteLine($"The answer is = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Division by zero isn't allowed");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Input!!!");
                        break;
                }

                Console.WriteLine("Enter \"Y\" to restart and \"N\" to end the program..........");
            }
            while (Console.ReadLine()?.ToUpper() == "Y");

            Console.WriteLine("Have a Good Day!");
            Console.ReadKey();
            Console.Beep();
        }
    }
}