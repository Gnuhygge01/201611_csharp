using System;
using System.Text;

namespace _04RefType
{
    class Program
    {
        static void Main(string[] args)
        {

            int måned1 = 10000;
            int måned2 = 14000;
            int måned3 = 30000;
            int måned4 = 35000;
            double gns = (måned1 + måned2 + måned3 + måned4) / 4;
            Console.WriteLine(gns);


            int[] månedløn = { 10000, 14000, 30000, 35000, 40000 };
            double gns1 = 0;
            for (int i = 0; i < månedløn.Length; i++)
            {
                gns1 += månedløn[i];
            }
            gns1 = gns1 / månedløn.Length;
            Console.WriteLine(gns1);

            int[] test;
            test = new int[5];
            test[0] = 4500;
            test[1] = 200;
            // ....

            int[] test1;
            test1 = new int[100000];
            test1[0] = 10000;

            //test = test1;

            Console.WriteLine(test[0]);
            Console.WriteLine(test1[0]);

            System.Array.Sort(test);

            System.String navn1;
            navn1 = "Mikkel";
            string navn2 = "Mathias";
            var navn3 = "Michell";

            var s = navn1.Substring(2, 2);
            string l = navn1.ToLower();

            // sammenligner værdier
            if (navn1 == navn2) { } else { }
            string nytNavn = navn1 + navn2;

            string a = "";
            System.Text.StringBuilder sb;
            sb = new System.Text.StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                a += i.ToString() + ";";

                sb.Append(i.ToString());
                sb.Append(";");
            }


            


            string tal = "1,5,24,7,5,7,5";
            var talArray = tal.Split(',');

            string res = string.Format("jh dgh df {0} sg {1} sdf {0} g", 3, 6);
            int tal2 = 20000;
            string template = $"tallet er {tal2.ToString("n2")} men vi antager at..... { tal2/2}";
            Console.WriteLine(template);

            string t = "lkdgjsdlæfjgsdfj \tab";
            string sti = "c:\\temp\\test.txt";
            string sti2 = @"c:\temp\test.txt";

            // Duer ikke rigtigt
            int y = int.MinValue;
            if (y == int.MinValue) { }

            // brug nullable
            Nullable<int> ah1;
            int? ah;
            ah = null;
            if (ah.HasValue) {
                Console.WriteLine(ah);
            } else {

            }

            bool? checket;
            checket = false;
            checket = true;
            checket = null;

            // Virker ikke....
            //bool checket2;
            //checket2 = checket;

            if (true) { } else { }

            if (true)
                Console.WriteLine("sand");

            Console.WriteLine("sand");

            DayOfWeek u = DayOfWeek.Friday;
            switch (u)
            {
                case DayOfWeek.Sunday:
                    break;
                case DayOfWeek.Monday:


                    break;
                case DayOfWeek.Tuesday:

                    break;
                case DayOfWeek.Wednesday:
                    break;
                case DayOfWeek.Thursday:                    
                case DayOfWeek.Friday:
                case DayOfWeek.Saturday:


                    break;
                default:
                    break;
            }


            for (int i = 0; i < 10; i++)
            {

            }

            for (int i = 10; i >0; i--)
            {

            }

            for (int i = 0; i < 10; i=i+2)
            {

            }

            
            foreach (string item in talArray)
            {                
                Console.WriteLine(item);
            }

            for (int i = 0; i < talArray.Length; i++)
            {
                Console.WriteLine(talArray[i]);
            }

                DateTime tid = DateTime.Now.AddSeconds(4);
            do
            {
                Console.Write("*");
            } while (DateTime.Now < tid);

            for (int i = 0; i < 10; i++)
            {

            }
            return;
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            System.Random rnd = new Random();
            int antal = 100000;
            string tals = string.Empty;
            sw.Start();
            for (int i = 0; i < antal; i++)
            {
                tals += rnd.Next(1, 1000).ToString() + ",";
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds + " " + sw.ElapsedTicks);

            sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            int[] tt = new int[antal];
            for (int i = 0; i < antal; i++)
            {
                tt[i] = rnd.Next(1, 1000);
            }
            string res3 = string.Join(",", tt);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds + " " + sw.ElapsedTicks);


            sw = new System.Diagnostics.Stopwatch();
            StringBuilder sb1 = new StringBuilder();
            sw.Start();
            for (int i = 0; i < antal; i++)
            {
                sb.Append(rnd.Next(1, 1000).ToString());
                sb.Append(";");
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds + " " + sw.ElapsedTicks);
            


        }
    }
}
