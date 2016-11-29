using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Prop
{
    class B
    {
        // Offentligt felt (nej tak)
        public string Navn;

        
        // start
        public string Land { get; private set; }

        //private string land;

        //public string Land
        //{
        //    get {
        //        return land; }
        //    set {
        //        land = value; }
        //}



        public B()
        {

        }

        public B(string land)
        {
            this.Land = land;
        }

    }
}
