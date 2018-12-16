using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giococ
{
    class Program
    {
        static void Main(string[] args)
        {            
            for(int i = 1; i < 10; i += 2){

                for(int k = 0; k < (4 - i / 2); k++){
                    Console.Write(" ");
                }

                for(int j = 0; j < i; j++){

                    Console.Write("*");
                    
                }

                Console.WriteLine("");
            }
                        
            Console.ReadKey();

        }
    }
}
