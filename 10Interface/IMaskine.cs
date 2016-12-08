using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Interface
{
    interface IMaskine
    {
        bool Start();
        bool Stop();
        void LogFejl(string txt);
    }
}
