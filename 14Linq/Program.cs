using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            var lst = new PersonNuGetPackage.PersonRepositoryRandom().Get10People();
            foreach (var p in lst)
            {
                Console.WriteLine(p.Name);
            }

            Console.WriteLine();
            var res1 = from p in lst select p;
            var res11 = lst;
            foreach (var p in res11)
                Console.WriteLine(p.Name);

            Console.WriteLine();
            var res2 = from p in lst orderby p.Gender, p.Name select p;
            var res22 = lst.OrderBy(i => i.Gender).ThenBy(i => i.Name);
            foreach (var p in res22)
                Console.WriteLine(p.Name + " " + p.Gender);

            Console.WriteLine();
            var res3 = from p in lst where p.Height> 150 && p.IsHealthy==true orderby p.Gender, p.Name select p;
            var res33 = lst.Where(i => i.Height > 150 && i.IsHealthy)
                .OrderBy(i => i.Gender)
                .ThenBy(i => i.Name);

            foreach (var p in res33)
                Console.WriteLine(p.Name + " " + p.Gender);


            Console.WriteLine();
            //var res4 = from p in lst where p.Height > 150 && p.IsHealthy == true orderby p.Gender, p.Name select p;
            var res44 = lst.Where(i => i.Height > 150 && i.IsHealthy)
                .OrderBy(i => i.Gender)
                .ThenBy(i => i.Name)
                .Select(i => new { Navn = i.Name, Højde = i.Height });

            foreach (var p in res44)
                Console.WriteLine(p.Navn);



        }
    }
}
