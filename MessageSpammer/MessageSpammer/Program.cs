using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;
using System.Threading;

namespace MessageSpammer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ComputerInfo d = new ComputerInfo();

            ulong ramDisponibileByte = d.AvailablePhysicalMemory;
            ulong ramInUsoByte = d.TotalPhysicalMemory - d.AvailablePhysicalMemory;

            ulong ramDisponibileKiloByte = ramDisponibileByte / 1024;
            ulong ramInUsoKiloByte = ramInUsoByte / 1024;


            ulong ramBella = (ramDisponibileByte > ramInUsoByte) ? ramDisponibileByte : ramInUsoByte;

            while (true)
            {
                Console.WriteLine("Ram in uso: {0}", ramInUsoKiloByte);
                Console.WriteLine("Ram disponibile: {0}", ramDisponibileKiloByte);
                Thread.Sleep(500);
                Console.Clear();
            }

        }
    }
}
