using System;
using System.Text.RegularExpressions;

namespace Lab1
{
    public class Menu
    {
        /// <summary>
        /// The object of class Calculator
        /// </summary>
        /// <returns></returns>
        private Calculator Calculator = new Calculator();

        /// <summary>
        /// Method that implements work with input data
        /// </summary>
        public void Commands()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("Enter command");
                string com = Console.ReadLine();
                string[] command = Regex.Split(com, @"\s+"); //x знак y, sqrt x, pow x степ

                try
                {
                    if (command[0] == "stop")
                    {
                        flag = false;
                    }
                    else
                    {
                        if (command[1] == "+")
                        {
                            Console.WriteLine(Calculator.Addition(double.Parse(command[0]), double.Parse(command[2])));
                        }
                        else
                        {
                            if (command[1] == "-")
                            {
                                Console.WriteLine(Calculator.Subtraction(double.Parse(command[0]), double.Parse(command[2])));
                            }
                            else
                            {
                                if (command[1] == "*")
                                {
                                    Console.WriteLine(Calculator.Multiplication(double.Parse(command[0]), double.Parse(command[2])));
                                }
                                else
                                {
                                    if (command[1] == "/")
                                    {
                                        Console.WriteLine(Calculator.Division(double.Parse(command[0]), double.Parse(command[2])));
                                    }
                                    else
                                    {
                                        if (command[0] == "pow")
                                        {
                                            Console.WriteLine(Calculator.Degree(double.Parse(command[1]), double.Parse(command[2])));
                                        }
                                        else
                                        {
                                            if (command[0] == "sqrt")
                                            {
                                                Console.WriteLine(Calculator.Root(double.Parse(command[1]), double.Parse(command[2])));
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
                catch (FormatException ex) { Console.WriteLine(ex); }
                catch (IndexOutOfRangeException ex) { Console.WriteLine(ex); }
                catch (Exception ex) { Console.WriteLine(ex); }

            } while (flag);
        }

        /// <summary>
        /// Using for test or if user can't use console 
        /// </summary>
        /// <param name="com"></param>
        public void Commands(string com)
        {

            string[] command = Regex.Split(com, @"\s+"); //x знак y, sqrt x, pow x степ

            try
            {
                if (command[0] == "stop")
                {
                }
                else
                {
                    if (command[1] == "+")
                    {
                        Console.WriteLine(Calculator.Addition(double.Parse(command[0]), double.Parse(command[2])));
                    }
                    else
                    {
                        if (command[1] == "-")
                        {
                            Console.WriteLine(Calculator.Subtraction(double.Parse(command[0]), double.Parse(command[2])));
                        }
                        else
                        {
                            if (command[1] == "*")
                            {
                                Console.WriteLine(Calculator.Multiplication(double.Parse(command[0]), double.Parse(command[2])));
                            }
                            else
                            {
                                if (command[1] == "/")
                                {
                                    Console.WriteLine(Calculator.Division(double.Parse(command[0]), double.Parse(command[2])));
                                }
                                else
                                {
                                    if (command[0] == "pow")
                                    {
                                        Console.WriteLine(Calculator.Degree(double.Parse(command[1]), double.Parse(command[2])));
                                    }
                                    else
                                    {
                                        if (command[0] == "sqrt")
                                        {
                                            Console.WriteLine(Calculator.Root(double.Parse(command[1]), double.Parse(command[2])));
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            catch (FormatException ex) { Console.WriteLine(ex); }
            catch (IndexOutOfRangeException ex) { Console.WriteLine(ex); }
            catch (Exception ex) { Console.WriteLine(ex); }


        }

    }
}
