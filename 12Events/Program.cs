using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Events
{
    class Program
    {
        public delegate void DelegateTest(string tekst);
        public delegate int BeregnerDelegate(int a, int b);

        static void Main(string[] args)
        {

            DelegateTest funcRef = new DelegateTest(Test);
            Test("1");
            funcRef.Invoke("2");

            DelegateTest funcRef2 = Test;
            funcRef2 += Test2;
            funcRef2.Invoke("2");

            BeregnerDelegate beregner = Add;
            beregner += Sub;
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var f in beregner.GetInvocationList())
            {
                Console.WriteLine(f.DynamicInvoke(5, 5));
            }

            Console.WriteLine();
            var fu = FindFunktion();
            Console.WriteLine(fu(5, 5));
            Console.WriteLine(FindFunktion()(4, 4));


            //

            Action<string> minA = Test;
            minA += Test2;
            minA("xfljldjdkjfg");

            Action<string, int, DateTime> minB;

            // sidste args definerer returtypen
            Func<int, int, int> MinBeregner = Add;
            MinBeregner(5, 4);

            Predicate<int> testp = (i) => i < 10;
            var e = testp(1);


            Hund h = new Hund();
            h.SigNoget += H_SigNoget;

            System.IO.FileSystemWatcher fw 
                = new System.IO.FileSystemWatcher(@"c:\temp");
            fw.Created += Fw_Created;
            fw.EnableRaisingEvents = true;
            do
            {

            } while (true);




        }

        private static void Fw_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine(e.FullPath);
        }

        private static void H_SigNoget(string txt)
        {
            throw new NotImplementedException();
        }

        static BeregnerDelegate FindFunktion() {
            if (DateTime.Now.Millisecond % 2 == 0) {
                return Add;
            } else {
                return Sub;
            }
        }

        static void MinLog(string t, DelegateTest f) {
            // logik...
            f(t);
            // logik...
        }


        static int Add(int i, int x) {
            return i + x;
        }

        static int Sub(int i, int x)
        {
            return i - x;
        }

        static void Test(string txt) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(txt);
        }

        static void Test2(string txt) {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(txt);
        }

    }
}
