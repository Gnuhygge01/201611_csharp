using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Fornavn = "X";
            p.Efternavn = "Y";
            //Console.WriteLine(p.FuldtName());
            p.Log();
            Instruktør i = new Instruktør();
            i.Fornavn = "X1";
            i.Efternavn = "Y1";
            //Console.WriteLine(i.FuldtName());
            i.Log();


            Person p1 = new Instruktør();
            Instruktør i1 = (Instruktør)p1;

            Test t = new Test();
            //Console.WriteLine(t.ToString()); 

            A a = new A();
            a.Log();

            B b = new B();
            b.Log();

            A aa = new B();
            aa.Log();

            
            
            A aaa = (A)b;

            A aaaa = b as A;
            if (aaaa != null) { }

            

            object o = a;







        }
    }
}
