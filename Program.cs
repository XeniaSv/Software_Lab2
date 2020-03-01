using System;

namespace Lab1
{
    class Program
    {
        /// <summary>
        /// The point of enter
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Commands();
            BinaryParser parser = new BinaryParser();
            byte[] sequence = new byte[] {0x00,0x01,0x02,0x03};
            Console.WriteLine(parser.BinaryParserCalcMatch(sequence, '+'));
        }
    }
}
