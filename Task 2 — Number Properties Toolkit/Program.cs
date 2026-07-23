// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1 {
    class Program { 

   public static void Main(string[] args)
        {


            Console.WriteLine("Enter a number : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n");

            isprime(x);


            ispalindrom(x);


            isarmstrong(x);


            PrintFactorial(x);


            static void isprime(int x)
            {

                if (x < 0)
                {
                    Console.WriteLine(x + " is not a prime number.");
                }
                for (int i = 2; i < x / 2; i++)
                {
                    if (x % i == 0)
                    {

                        Console.WriteLine($"{x} is not a prime number.");
                        return;

                    }
                }

                Console.WriteLine($"{x} is a prime number.");

            }
            static void ispalindrom(int x)
            {
                if (x < 0)
                {
                    Console.WriteLine($"{x} is not a palindrome number.");
                }
                int original = x;
                int reverse = 0;

                while (original > 0)
                {
                    int digit = original % 10;
                    reverse = (reverse * 10) + digit;
                    original = original / 10;
                }
                Console.WriteLine("Reverse value is : " + reverse);

            }
            static void isarmstrong(int x)
            {
                if (x < 0)
                {
                    Console.WriteLine("number is less than 0 ");
                }
                int temp = x;
                int sum = 0;
                while (temp > 0)
                {
                    {
                        int digit = temp % 10;
                        sum += digit * digit * digit;
                        temp = temp / 10;

                    }
                }
                Console.WriteLine("after taking cube of each value sum of the values is : " + sum);
            }

            static void PrintFactorial(int x)
            {
                if (x > 0)
                {
                    long ans = 1;
                    for (int i = 1; i <= x; i++)
                    {

                        ans *= i;

                    }
                    Console.WriteLine($"Factorial of number {x} is : " + ans);
                }

            }
        }
    } }
