﻿using System;
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
            Console.WriteLine(p.FuldtName());
            
            Instruktør i = new Instruktør();
            i.Fornavn = "X1";
            i.Efternavn = "Y1";
            Console.WriteLine(i.FuldtName());

            Person p1 = new Instruktør();
            Instruktør i1 = (Instruktør)p1;
            




        }
    }
}
