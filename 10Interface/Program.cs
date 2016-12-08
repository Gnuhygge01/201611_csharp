using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            TransportBånd t = new TransportBånd();
            t.Start();
            t.Stop();
            

            IMaskine tt = new TransportBånd();
            tt.Start();
            TransportBånd ttt = (TransportBånd)tt;
            ttt.Start();
            Console.WriteLine();

            IMaskine[] maskiner = new IMaskine[2];
            maskiner[0] = new TransportBånd();
            maskiner[1] = new Køler();
            for (int i = 0; i < maskiner.Length; i++)
            {
                maskiner[i].Start();
            }


        }
    }
}
