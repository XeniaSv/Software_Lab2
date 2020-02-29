using Xunit;
using Lab1;
using System.IO;
using System;

public class UnitTest1{
    /// <summary>
    /// The object of class Menu
    /// </summary>
    /// <returns></returns>
    private Menu menu = new Menu();
    [Fact]

    /// <summary>
    /// Input addition test
    /// </summary>
    public void TestMethodInputAddition()
        {
            using(StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                menu.Commands("2 + 2");
                string excepted = $"4{Environment.NewLine}";
                Assert.Equal(excepted, sw.ToString());

            }     
        }

        /// <summary>
        /// Input substraction test
        /// </summary>
        [Fact]
        public void TestMethodInputSubstraction()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                menu.Commands("2 - 2");
                string excepted = $"0{Environment.NewLine}";
                Assert.Equal(excepted, sw.ToString());

            }
        }


        /// <summary>
        /// Input multiplication test
        /// </summary>
        [Fact]
        public void TestMethodInputMultiply()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                menu.Commands("2 * 3");
                string excepted = $"6{Environment.NewLine}";
                Assert.Equal(excepted, sw.ToString());

            }
        }

        /// <summary>
        /// Input division test
        /// </summary>
        [Fact]
        public void TestMethodInputDivision()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                menu.Commands("2 / 2");
                string excepted = $"1{Environment.NewLine}";
                Assert.Equal(excepted, sw.ToString());

            }
        }

        /// <summary>
        /// Input raising the number of degree test
        /// </summary>
        [Fact]
        public void TestMethodInputDegree()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                menu.Commands("pow 2 3");
                string excepted = $"8{Environment.NewLine}";
                Assert.Equal(excepted, sw.ToString());

            }
        }

        /// <summary>
        /// Input taking the root of a number test
        /// </summary>
        [Fact]
        public void TestMethodInputRoot()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                menu.Commands("sqrt 16 0,5");
                string excepted = $"4{Environment.NewLine}";
                Assert.Equal(excepted, sw.ToString());

            }
        }
    
}