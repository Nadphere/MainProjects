using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shut
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check(string myString)
            {
                string first = myString.Substring(0, myString.Length / 2);
                char[] arr = myString.ToCharArray();

                Array.Reverse(arr);

                string temp = new string(arr);
                string second = temp.Substring(0, temp.Length / 2);

                return first.Equals(second);
            }

            Console.WriteLine("Write a sentence. i'll see if it's a palindrome.");
            string frase = Console.ReadLine();

            Console.Clear();

            Console.WriteLine(check(frase));

            Console.ReadKey();

        }
    }
}
