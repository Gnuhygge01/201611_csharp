using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Events
{
    public delegate void SigNogetDelegate(string txt);

    class Hund
    {
        public event SigNogetDelegate SigNoget;

    }
}
