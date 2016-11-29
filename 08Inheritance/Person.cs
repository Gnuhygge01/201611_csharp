using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Inheritance
{
    class Person
    {
        public int Id { get; set; }
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public string FuldtName() {
            return Fornavn + " " + Efternavn;
        }

        public virtual void Log() {
            Console.WriteLine("Log fra person");
        }
    }

    class Instruktør : Person {
        public string MedarbejderId { get; set; }

        public override void Log()
        {
            Console.WriteLine("Log fra Instruktør");
        }

        public void SkrivLønSeddel() {            
            Console.WriteLine("D");
        }
    }

    sealed class InstruktørElev : Instruktør
    {
        public int Mødetid { get; set; }

    }

    

    class Elev : Person
    {
        public string ElevId { get; set; }

        public void GivAdgang()
        {            
        }
    }

     
}
