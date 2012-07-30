using System;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class TestFizzBuzz
    {
        [TestCase(10,"Buzz")]
        [TestCase(9,"Fizz")]
        [TestCase(8,"8")]
        [TestCase(7,"7")]
        [TestCase(6,"Fizz")]
        [TestCase(5,"Buzz")]
        [TestCase(4,"4")]
        [TestCase(3,"Fizz")]
        [TestCase(2,"2")]
        [TestCase(1,"1")]
        [Test]
        public void If_Given_Number_Should_Return_Expected_String(int InputNumber,string expectedNumber)
        {
            var fizzBuzz = new FizzBuzz();
            var inputNumberInStringFormat = fizzBuzz.ConvertNumberToString(InputNumber);
            Assert.That(inputNumberInStringFormat,Is.EqualTo(expectedNumber));
        }
    }
    
    public class FizzBuzz
    {
        
        public String ConvertNumberToString(int inputNumber)
        {
            string stringFormat = "";

           
            if(IfNumberDividedByThree(inputNumber) )
            {
               
                stringFormat = "Fizz";
               
            }
            else if(IfNumberDividedByFive(inputNumber))
            {
               
                stringFormat = "Buzz";
            }
            else
            {
                stringFormat = inputNumber.ToString();

            }
            return stringFormat;  
        }

        private bool IfNumberDividedByFive(int inputNumber)
        {
            return inputNumber%5==0;
        }

        private bool IfNumberDividedByThree(int inputNumber)
        {
            return inputNumber%3==0;
        }
    }
}
