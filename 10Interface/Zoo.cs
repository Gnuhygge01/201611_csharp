using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Interface
{
    class Zoo : IEnumerable, IDisposable
    {

        private List<Dyr> dyr = new List<Dyr>();

        public void Dispose()
        {
            // ryd op
            Console.WriteLine("dør");
        }

        public IEnumerator GetEnumerator()
        {
            return dyr.GetEnumerator();
        }

        public void TilføjDyr(Dyr d) {
            dyr.Add(d);
        }


    }
}
