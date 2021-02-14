using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace BinaryBuilder {

    public class Builder {
        
        public static void Main() {
            Console.WriteLine("Binary Table Creator");
            Console.WriteLine("  by Marco Attia");
            Thread.Sleep(2000);
            Console.Clear();
            do {
                Console.Write("Please input the desired value:");
                int _bit_Size = Convert.ToInt32(Console.ReadLine());
                Console.Write("{0} Bit size selected. Confirm?", _bit_Size);
                Console.Clear();
            
                int _bit_bitCountMaxLen = Math.Pow(2, _bit_Size).ToString().Length;
                for (int _bit_currBit = 0; _bit_currBit < Math.Pow(2, _bit_Size); _bit_currBit++) {
                    string _bit_currBitCount = (_bit_currBit + 1).ToString().PadRight(_bit_bitCountMaxLen, ' ');
                    Console.Write("| {0} |", _bit_currBitCount);
                    for (int _bit_currBitSize = _bit_Size; _bit_currBitSize > 0; _bit_currBitSize--) {
                        int _bit_currBitRemainder = _bit_currBit % (int)Math.Pow(2, _bit_currBitSize);
                        int _bit_currBitBinaryValue = (int)Math.Round(_bit_currBitRemainder
                                / (double)Math.Pow(2, _bit_currBitSize), MidpointRounding.AwayFromZero);
                        Console.Write( _bit_currBitBinaryValue + "|");
                    }
                    // start next bit line.
                    Console.WriteLine();
                    Console.WriteLine("".PadRight(_bit_Size * 2 + _bit_bitCountMaxLen + 4, '-'));
            
                }   
            } while (Console.ReadKey(false).Key != ConsoleKey.Escape);
        }
    }
}