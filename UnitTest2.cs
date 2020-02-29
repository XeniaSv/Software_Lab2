using Xunit;
using Lab1;
using System.IO;
using System;

public class UnitTest2{
    /// <summary>
    /// The object of class Calculator
    /// </summary>
    /// <returns></returns>
    private Calculator Calculator = new Calculator();

        /// <summary>
        /// Output addition test
        /// </summary>
        [Fact]
        public void TestMethodOutputAddition()
        {
            double result = Calculator.Addition(2, 2);
            double excepted = 4;
            Assert.Equal(excepted, result);
        }
        
        /// <summary>
        /// Output substraction test
        /// </summary>
        [Fact]
        public void TestMethodOutputSubstraction()
        {
            double result = Calculator.Subtraction(2, 2);
            double excepted = 0;
            Assert.Equal(excepted, result);
        }

        /// <summary>
        /// Output multiplication test
        /// </summary>
        [Fact]
        public void TestMethodOutputMultiply()
        {
            double result = Calculator.Multiplication(2, 3);
            double excepted = 6;
            Assert.Equal(excepted, result);
        }

        /// <summary>
        /// Output division test
        /// </summary>
        [Fact]
        public void TestMethodOutputDivision()
        {
            double result = Calculator.Division(2, 2);
            double excepted = 1;
            Assert.Equal(excepted, result);
        }

        /// <summary>
        /// Output raising the number of degree test
        /// </summary>
        [Fact]
        public void TestMethodOutputDegree()
        {
            double result = Calculator.Degree(2, 3);
            double excepted = 8;
            Assert.Equal(excepted, result);
        }

        /// <summary>
        /// Output taking the root of a number test
        /// </summary>
        [Fact]
        public void TestMethodOutputRoot()
        {
            double result = Calculator.Root(16, 0.5);
            double excepted = 4;
            Assert.Equal(excepted, result);
        }

        
        /// <summary>
        /// Output taking the abs of a number test
        /// </summary>
        [Fact]
        public void TestMethodOutputAbs()
        {
            double result = Calculator.Abs(-16);
            double excepted = 16;
            Assert.Equal(excepted, result);
        }

        
        /// <summary>
        /// Output taking the factorial of a number test
        /// </summary>
        [Fact]
        public void TestMethodOutputFactorial()
        {
            double result = Calculator.Factorial(3);
            double excepted = 6;
            Assert.Equal(excepted, result);
        }




}


