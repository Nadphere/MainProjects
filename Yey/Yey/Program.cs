using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Yey
{
    class Vars
    {
        public string Url { get; set; }
        
        public Vars(string url)
        {
            Url = url;
        }
        
    }

    class Program
    {
        Vars v = new Vars("https://www.youtube.com/watch?v=6Dh-RL__uN4");

        bool run = true;
        
        while(bool run == true)
        
    }
}