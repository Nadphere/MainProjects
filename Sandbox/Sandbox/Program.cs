using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Employees
    {
        private List<int> Layer = new List<int>();

        public void addInt(int x)
        {
            Layer.Add(x);
        }

        public List<int> GetList()
        {
            return Layer;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Employees employees = new Employees();

            List<int> lista = employees.GetList();

            bool RunLoop = true;

            while(RunLoop == true){
                Console.WriteLine("Inserire i propri numeri preferiti (-1 per uscire): ");
                int n = Convert.ToInt32 (Console.ReadLine());
                employees.addInt(n);

                if (n == -1)
                {
                    RunLoop = false;
                }

                Console.Clear();

                Console.WriteLine("Numeri preferiti: ");
                lista.ForEach(Console.WriteLine);


            }
        }
    }
}
