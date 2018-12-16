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

            string ToHex(int decimalNum)
            {
                string Hex = decimalNum.ToString("X");

                return Hex;
            }

            int choice;
            int num;
            string hexNum;
            int intNum;
            string stringNum;

            string version = "1.05";

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("DECIMAL AND HEX CONVERTER. BY NADPHER (v {0})", version);
                Console.ResetColor();

                Console.WriteLine("To convert a decimal number to hexadecimal, press 1.\nTo convert a hexadecimal number to decimal, press 2.\nTo quit, press 0.\n");

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 0)
                {
                    break;
                }
                else if (choice == 1)
                {
                    while(true){
                        try{
                            Console.Clear();

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("DECIMAL AND HEX CONVERTER. BY NADPHER (v {0})", version);
                            Console.ResetColor();

                            Console.WriteLine("Write the number you want to convert: ");

                            
                            num = Convert.ToInt32(Console.ReadLine());
                            hexNum = ToHex(num);
                            Console.Clear();

                            Console.WriteLine("The number in hexadecimal is {0}", hexNum);
                            Console.ReadKey();
                            Console.Clear();

                            break;

                            
                        }catch{
                            Console.WriteLine("Invalid input.");
                            Console.ReadKey();
                            continue;
                        }
                    }
                }
                else if (choice == 2)
                {
                    while(true){
                        try{
                            Console.Clear();

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("DECIMAL AND HEX CONVERTER. BY NADPHER (v {0})", version);
                            Console.ResetColor();

                            Console.WriteLine("Insert the number you want to convert: ");

                            hexNum = Console.ReadLine();                            
                            intNum = Convert.ToInt32(hexNum, 16);
                            stringNum = Convert.ToString(intNum);

                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("DECIMAL AND HEX CONVERTER. BY NADPHER (v {0})", version);
                            Console.ResetColor();

                            Console.WriteLine("The number in decimal is {0}", stringNum);
                            Console.ReadKey();
                            Console.Clear();
                            

                            intNum = Convert.ToInt32(hexNum, 16);
                            stringNum = Convert.ToString(intNum);

                            Console.Clear();

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("DECIMAL AND HEX CONVERTER. BY NADPHER (v {0})", version);
                            Console.ResetColor();

                            Console.WriteLine("The number in decimal is {0}", stringNum);
                            Console.ReadKey();
                            Console.Clear();

                            break;

                        }catch{
                            Console.WriteLine("Invalid input.");
                            Console.ReadKey();
                            continue;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Choose a valid option!");
                    Console.Clear();
                }


            }

        }
    }
}
