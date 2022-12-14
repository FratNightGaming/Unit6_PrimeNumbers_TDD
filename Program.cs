using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Xunit;

namespace PrimeNumbers
{
    internal class Program
    {
        
    }
}
/*What will the application do?
 
The application locates prime numbers in a sequence (ex: 1st prime number is 2, 10th prime number is 29, etc.).
The application prompts the user which sequenced prime they want to locate.
The application displays the prime number and its sequence number, and prompts the user to find another prime.
When the user chooses to end his or her search, the application displays a goodbye message.

Build Specifications:

Pair Program! Work with your assigned partner and follow Test-Driven Development.
Create a Prime Numbers class with a GetPrime() method.GetPrime returns the nth prime number where n is the method’s integer parameter. (1 returns 2, 2 returns 3, 3 returns 5, etc.
Class is properly formed—1 point
Method has proper header—1 point
Method returns the correct prime number for the argument—2 points
Create Unit Tests for your program, as you go, following TDD methodology. Write a test, fail it, implement code, pass it, repeat.
Solution has at least 5 valid Unit Tests—5 points (1 each)
Create a Main which takes user input and, using the class, displays the proper prime
Program takes integer input correctly and displays the prime—1 point

Push the finished program to one partner’s GitHub. Each partner should submit that link in the LMS.

Hints:
Don’t get the algorithm backwards; when you enter 6, you want the 6th prime number, which is 13. (Don’t enter 13 to find 6.)

Extra Challenges:
Consider efficiency.What algorithm would have the greatest time efficiency? Now that you’ve got tests, refactor your code for efficiency.*/
