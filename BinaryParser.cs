using MiniBinaryParser;
using System;
using System.IO;

namespace Lab1{
    class BinaryParser
    {
        private Calculator calculator = new Calculator();

        public byte BinaryParserCalcMatch(byte[] sequence, char oper){
            Match match = sequence.Parse(Endian.Big, (byte)0x02, (byte)0x03);
            byte[] matchedSequence = match.MatchedBytes;
            if (oper == '+'){
                return calculator.Addition(matchedSequence[0], matchedSequence[1]);
            }

            if (oper == '-'){
                return calculator.Subtraction(matchedSequence[0], matchedSequence[1]);
            }

            if (oper == '*'){
                return calculator.Multiplication(matchedSequence[0], matchedSequence[1]);
            }

            if (oper == '/'){
                return calculator.Division(matchedSequence[0], matchedSequence[1]);
            }
            
            return 0;
        }
    }
}