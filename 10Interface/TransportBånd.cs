using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Interface
{
    class TransportBånd : IMaskine
    {

        public int Antal { get; set; }

        public void Test() { }

        public void LogFejl(string txt)
        {
            System.IO.File.WriteAllText(@"c:\temp\txt.txt", txt);
        }

        public bool Start()
        {
            Console.WriteLine("Nu starter jeg");
            return true;
        }

        public bool Stop()
        {
            Console.WriteLine("Nu stopper jeg");
            return false;

        }
    }
}
