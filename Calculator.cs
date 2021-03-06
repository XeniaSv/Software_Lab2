using System;
namespace Lab1
{
    public class Calculator
    {
        /// <summary>
        /// Variable storing the last operation
        /// </summary>
        private double res;
        private byte res1;

        /// <summary>
        /// Method returns the result of the operation of addition two numbers
        /// </summary>
        /// <param name="value1">
        /// First number
        /// </param>
        /// <param name="value2">
        /// Second number
        /// </param>
        /// <returns></returns>
        public double Addition(double value1, double value2){
            res = value1 + value2;
            return res;
        }
        public byte Addition(byte value1, byte value2){
            res1 = value1;
            res1 += value2;
            return res1;
        }

        /// <summary>
        /// Method returns the result of the operation of subtracting two numbers
        /// </summary>
        /// <param name="value1">
        /// First number
        /// </param>
        /// <param name="value2">
        /// Second number
        /// </param>
        /// <returns></returns>
        public double Subtraction(double value1, double value2)
        {
            res = value1 - value2;
            return res;
        }
        public byte Subtraction(byte value1, byte value2){
            res1 = value1;
            res1 -= value2;
            return res1;
        }

        /// <summary>
        /// Method returns the result of the operation of multiplication two numbers
        /// </summary>
        /// <param name="value1">
        /// First number
        /// </param>
        /// <param name="value2">
        /// Second number
        /// </param>
        /// <returns></returns>
        public double Multiplication(double value1, double value2)
        {
            res = value1 * value2;
            return res;
        }

        public byte Multiplication(byte value1, byte value2){
            res1 = value1;
            res1 *= value2;
            return res1;
        }


        /// <summary>
        /// Method returns the result of the operation of division two numbers
        /// </summary>
        /// <param name="value1">
        /// First number
        /// </param>
        /// <param name="value2">
        /// Second number
        /// </param>
        /// <returns></returns>
        public double Division(double value1, double value2)
        {
            res = value1 / value2;
            return res;
        }

        public byte Division(byte value1, byte value2){
            res1 = value1;
            res1 /= value2;
            return res1;
        }

        /// <summary>
        /// Method returning the result of raising the number of degree
        /// </summary>
        /// <param name="value">
        /// Exponential number
        /// </param>
        /// <param name="degree">
        /// Degree
        /// </param>
        /// <returns></returns>
        public double Degree(double value, double degree)
        {
            res = Math.Pow(value, degree);
            return res;
        }

        /// <summary>
        /// Method returning the result of taking the root of a number
        /// </summary>
        /// <param name="value">
        /// Number under the root
        /// </param>
        /// <param name="degree">
        /// Root degree
        /// </param>
        /// <returns></returns>
        public double Root(double value, double degree)
        {
            res = Math.Pow(value, degree);
            return res;
        }

        /// <summary>
        /// Abs function
        /// </summary>
        /// <param name="value">enter number</param>
        /// <returns>Abs of enter number</returns>
        public double Abs(double value){
            res = Math.Abs(value);
            return res;
        }


        /// <summary>
        /// Factorial function
        /// </summary>
        /// <param name="value">enter number</param>
        /// <returns>Factorial of enter number</returns>
        public double Factorial(double value){
            if (value == 0){
                return res = 0;
            }
            if (value == 1){
                return res = 1;
            }
            res = value * Factorial(value -1);
            return res;
        }

        /// <summary>
        /// Function translate grade in radian
        /// </summary>
        /// <param name="grade">enter number</param>
        /// <returns>Radians</returns>
        public double TranslateInRadian(double grade){
            res = grade * Math.PI/180;
            return res;
        }

        /// <summary>
        /// Function translate radian in grade
        /// </summary>
        /// <param name="radian">enter number</param>
        /// <returns>Grades</returns>
        public double TranslateInGrade(double radian){
            res = radian * 180/Math.PI;
            return res;
        }

        /// <summary>
        /// Exponential function
        /// </summary>
        /// <param name="value">enter number</param>
        /// <returns>Exp of enter number</returns>
        public double Exp(double value){
            res = Math.Exp(value);
            return res;
        }

    }
}
