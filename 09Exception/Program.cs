using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Exception
{
    class Program
    {
        static void Main(string[] args)
        {

            throw new ApplicationException("der er sket en fejl");




            try
            {
                int y = 10;
                A();

            }

            catch (Exception ex)
            {
                // log ex....
            }
            finally
            {
                // evt luk/ryd op
            }
        }
        public static void A()
        {
            B();

        }

        public static int es() {
            return 1;
        }
        public static void B()
        {
            C();

        }
        public static void C()
        {
            D();
        }
        public static void D()
        {
            object o = null;
            o.ToString();
        }

    }


}

