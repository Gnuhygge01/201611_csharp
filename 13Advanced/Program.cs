using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teknologisk;
using System.Linq;

namespace _13Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = "sdlkfd";
            Console.WriteLine(Teknologisk.StringHelper.FindFørsteBogstav(t));
            Console.WriteLine(t.FindFørsteBogstav());

            List<string> l = new List<string>();
            // kdfjhg ldkshjg dkjgh sldkgh sdkfjgh 

            var p = new { navn = "Michell", alder = 10 };
            Console.WriteLine(p.navn);

        }
    }
}
