using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PrimeNumbers
{
    public class PrimeNumbers
    {
        public int GetPrime(int n)
        {
            List<int> primeNumbers = new List<int>();

            //if (IsPrime(n))
            //{
                for (int i = 1; i < n; i++)
                {

                    if (IsPrime(i))
                    {
                        primeNumbers.Add(i);

                    }
                }

                Console.WriteLine($"{n} is index {primeNumbers.Count} in prime number list.");
                return primeNumbers.Count;
            //}

            else
            {
                return -1;
            }
        }

        //method determines if a number is prime
        public bool IsPrime(int number)
        {
            int factorCount = 0;
            
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factorCount++;
                }
            }

            if (factorCount == 2)
            {
                Console.WriteLine($"{number} is prime.");
                return true;
            }

            else
            {
                Console.WriteLine($"{number} has {factorCount} factors. Therefore, {number} is not a prime number.");
                return false;
            }
        }
    }
}
/*
The application locates prime numbers in a sequence (ex: 1st prime number is 2, 10th prime number is 29, etc.).
The application prompts the user which sequenced prime they want to locate.
The application displays the prime number and its sequence number, and prompts the user to find another prime.
When the user chooses to end his or her search, the application displays a goodbye message.

Build Specifications:

Create a Prime Numbers class with a GetPrime() method.GetPrime returns the nth prime number where n is the method’s integer parameter. (1 returns 2, 2 returns 3, 3 returns 5, etc.
Class is properly formed—1 point
Method has proper header—1 point
Method returns the correct prime number for the argument—2 points

Create Unit Tests for your program, as you go, following TDD methodology. Write a test, fail it, implement code, pass it, repeat.
Solution has at least 5 valid Unit Tests—5 points (1 each)

Create a Main which takes user input and, using the class, displays the proper prime
Program takes integer input correctly and displays the prime—1 point

Hints:
Don’t get the algorithm backwards; when you enter 6, you want the 6th prime number, which is 13. (Don’t enter 13 to find 6.)

Extra Challenges:
Consider efficiency.What algorithm would have the greatest time efficiency? Now that you’ve got tests, refactor your code for efficiency.*/
