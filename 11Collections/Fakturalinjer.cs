using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _11Collections
{
    //class Fakturalinjer
    //{
    //    private List<FakturaLinje> linjer = new List<FakturaLinje>();

    //}

    class Fakturalinjer : List<FakturaLinje>
    {
        public double FakturaSum()
        {
            double d = 0;
            foreach (var item in this)
            {
                d += item.Beløb;
            }
            return d;
            
        }

        
    }

    class FakturaLinje {
        public double Beløb { get; set; }
    }
}
