using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Interface
{
    class MockRepository : IRepository
    {
        public List<Dyr> HentAlleDyr()
        {
            List<Dyr> l = new List<Dyr>();
            l.Add(new Dyr() { Navn = "Bulder" });
            l.Add(new Dyr() { Navn = "Fido" });
            return l;
        }
    }
}
