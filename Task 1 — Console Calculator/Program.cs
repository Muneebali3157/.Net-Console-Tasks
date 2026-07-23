// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace day1;
public class Calculator_with_Menu
{
    public static void Main(string[] args)
    {
        Runcalculator();
    }
    public static void Runcalculator()
    {
        Console.WriteLine("Welcome to the Calculator with Menu!");
        bool x = true;

        while (x)
        {
            Console.WriteLine("\n===== Calculator Menu ===== \n");
            Console.WriteLine("Press 1. Add  \nPress 2. Subtract \nPress 3. Multiply  \n" +
                "Press 4. Divide \nPress 5. Modulus  \nPress 6. Exit \n");
            Console.Write("Enter choice: ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input < 1 || input > 6)
            {
                Console.WriteLine("Invalid choice. Please try again.");
                continue;
            }
            if (input == 6)
            {
                Console.WriteLine("Exiting the calculator. Goodbye!");

                break;
            }
            Console.WriteLine("Enter first number: ");
            float num1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            float num2 = Convert.ToSingle(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine($"Result of  {num1} + {num2} =  {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"Result of  {num1} - {num2} =  {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"Result of  {num1} * {num2} =  {num1 * num2}");
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    else
                    {
                        Console.WriteLine($"Result of  {num1} / {num2} =  {num1 / num2}");
                    }
                    break;
                case 5:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Modulus by zero is not allowed.");
                    }
                    else
                    {
                        Console.WriteLine($"Result of  {num1} % {num2} =  {num1 % num2}");
                    }
                    break;


            }



        }
    }
}

