using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace PrimeNumbers
{
    public class PrimeNumbersTest
    {

        //Fact ot Theory tells VS this method is a unit test
        [Fact]
        public void PrimeCount2()
        {
            //Arrange - setup 
            PrimeNumbers pn = new PrimeNumbers();
            int expected = 3;
            //Act - run your code and grab the result 
            int actual = pn.GetPrime(2);
            //Assert - use a special class to compare actual vs expected and return the result 
            Assert.Equal(expected, actual);
        }

        public void PrimeCount3()
        {
            //Arrange - setup 
            PrimeNumbers pn = new PrimeNumbers();
            int expected = 5;
            //Act - run your code and grab the result 
            int actual = pn.GetPrime(3);
            //Assert - use a special class to compare actual vs expected and return the result 
            Assert.Equal(expected, actual);
        }

        public void PrimeCount4()
        {
            //Arrange - setup 
            PrimeNumbers pn = new PrimeNumbers();
            int expected = 7;
            //Act - run your code and grab the result 
            int actual = pn.GetPrime(4);
            //Assert - use a special class to compare actual vs expected and return the result 
            Assert.Equal(expected, actual);
        }

        public void PrimeCount5()
        {
            //Arrange - setup 
            PrimeNumbers pn = new PrimeNumbers();
            int expected = 11;
            //Act - run your code and grab the result 
            int actual = pn.GetPrime(5);
            //Assert - use a special class to compare actual vs expected and return the result 
            Assert.Equal(expected, actual);
        }

        public void PrimeCount6()
        {
            //Arrange - setup 
            PrimeNumbers pn = new PrimeNumbers();
            int expected = 13;
            //Act - run your code and grab the result 
            int actual = pn.GetPrime(6);
            //Assert - use a special class to compare actual vs expected and return the result 
            Assert.Equal(expected, actual);
        }
        /*[Fact]
        public void TestDvisibleBy5()
        {
            //Arrange 
            FizzBuzz fb = new FizzBuzz();
            string expected = "fizz";
​
            //Act 
            string actual = fb.ReturnFizzBuzz(10);
​
            //Assert 
            Assert.Equal(expected, actual);
        }
​
        [Fact]
        public void TestBoth()
        {
            //Arrange 
            //In unit tests it is best practice to make a fresh object 
            //each test you run, that way it starts with a blank slate 
            //(But that only really matter if you have data in your object)
            FizzBuzz fb = new FizzBuzz();
            string expected = "fizzbuzz";
​
            //Act 
            string actual = fb.ReturnFizzBuzz(15);
​
            //Assert 
            Assert.Equal(expected, actual);
        }
​
        [Fact]
        public void TestNonDivisible()
        {
            //Arrange 
            FizzBuzz fb = new FizzBuzz();
            string expected = "";
​
            //Act 
            string actual = fb.ReturnFizzBuzz(8);
​
            //Assert
            Assert.Equal(expected, actual);
        }*/
    }
}
/*The application locates prime numbers in a sequence (ex: 1st prime number is 2, 10th prime number is 29, etc.).
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
