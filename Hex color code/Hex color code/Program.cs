using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hex_color_code
{
    class Program
    {
        static void Main(string[] args)
        {

            string ToHex(int red, int green, int blue)
            {
                string redHex = red.ToString("X");
                string greenHex = green.ToString("X");
                string blueHex = blue.ToString("X");

                return "#" + redHex + greenHex + blueHex;

            }

            string choice;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("DECIMAL AND HEX CONVERTER. BY NADPHER (v 1.0)");
                Console.ResetColor();

                Console.WriteLine("To convert a decimal number to hexadecimal, press 1.\nTo convert a hexadecimal number to decimal, press 2.\nTo quit, press 0.\n");

                choice = Convert.ToString(Console.ReadKey());

                
            }

        }
    }
}
