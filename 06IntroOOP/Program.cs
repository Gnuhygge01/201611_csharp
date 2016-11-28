using System;

namespace _06IntroOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Skakbrik s;
            s = new Skakbrik("Bonde");
            Skakbrik j = new Skakbrik("Hest");

            
            

            Skakbrik k;
            k = s;

            System.Random r = new Random();

            Person p;
            p = new Person();
            p.InitialiserPerson("x", "y", 10, "hjh");

            
        }
    }

    class Skakbrik
    {

        private DateTime start;
        private string brikType;


        //// ctor + tab
        //public Skakbrik()
        //{
        //    this.start = DateTime.Now;
        //    // this ikke nødvendigt
        //    brikType = "ikke angivet";
        //}

        public Skakbrik(string brikType)
        {
            this.start = DateTime.Now;
            this.brikType = brikType;
        }

    }
}
