using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            int sdf = 100;
            Test1(sdf);
            int test = 100;

            int[] t = { 1, 5, 1, 5, 3 };
            Test3(t);

            int y=0;
            int uu = 0;
            Test4(ref y, ref uu);
            int res = Test6();

            Test7("", "", true);
            Test7(cpr: "dfkgfk",
                  navn: "lkj",
                  test: true);

            ListFiler(@"c:\temp");
        }


        static void ListFiler(string sti) {
            foreach (var item in System.IO.Directory.GetFiles(sti))
                Console.WriteLine(item);
            foreach (var item in System.IO.Directory.GetDirectories(sti))
                ListFiler(item);
        }

        static int Test7(string navn, string cpr, bool erILive = true, bool test=false)
        {
            return 1;
        }


        static int Test6(int i = 2)
        {
            return i;
        }
        static int Sum(int i) {
            return i;
        }

        static int Sum(int i, int x)
        {
            return i + x;
        }

        static int Sum(int i, int x, int o)
        {
            return i + x + o;
        }


        static minReturVærdi Test5(int i)
        {
            // returnerer flere værdier
            minReturVærdi r;
            r.x = 11;
            r.y = 22;
            return r;
        }
        static void Test4(ref int i, ref int u)
        {
            u = 10;
            i = 10;
        }

        static void Test1(int i)
        {
            return;
            int test = 0;
            i = 10;


        }

        static void Test3(int[] tal) {
            tal[0] = 100000;
        }

        static int Test2(int i)
        {
            if (i == 1)
                return i * 2;
            else
                return 0;
        }
        struct minReturVærdi {
            public int x;
            public int y;

        }
    }

    
}
