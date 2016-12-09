using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _11Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] a = new string[10];


            System.Collections.ArrayList l = new System.Collections.ArrayList();
            l.Add("lkj");
            l.Add(1);
            l.Add(new System.Random());
            System.Collections.Queue q = new System.Collections.Queue();

            List<string> lst1 = new List<string>();
            lst1.Add("");
            //lst1.Add(true);
            //lst1.Add(new Dyr());
            foreach (var item in lst1)
            {}
            string[] sa = lst1.ToArray();

            List<Dyr> lst2 = new List<Dyr>();
            lst2.Add(new Dyr());
            foreach (var item in lst2)
            {}

            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "321");
            d.Add(2, "32dfgfd1");
            var g = d[2];

            

            Dictionary<string, Dyr> d2 = new Dictionary<string, Dyr>();
            d2.Add("1", new Dyr());
            d2.Add("2", new Dyr());
            var g2 = d2["2"];

            Stack<string> n = new Stack<string>();
            n.Push("");

            Dictionary<string, List<string>> d3
                = new Dictionary<string, List<string>>();


            Fakturalinjer f = new Fakturalinjer();
            f.Add(new FakturaLinje() { Beløb = 100 });
            f.Add(new FakturaLinje() { Beløb = 50 });
            Console.WriteLine(f.FakturaSum());

            int i = 10, u = 20;
            Console.WriteLine(i + " " + u);

            double s = 100, k = 200;
            Swap<double>(ref s, ref k);
            Console.WriteLine(s + " " + k);

            bool z = true, e = false;
            Swap<bool>(ref z, ref e);
            Swap(ref z, ref e);
            Console.WriteLine(z + " " + e);

        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T tmp = a;
            a = b;
            b = tmp;
        }


        //public static void Swap(ref int a, ref int b) {
        //    int tmp = a;
        //    a = b;
        //    b = tmp;
        //}
        //public static void Swap(ref string a, ref string b)
        //{
        //    string tmp = a;
        //    a = b;
        //    b = tmp;
        //}
    }
}
