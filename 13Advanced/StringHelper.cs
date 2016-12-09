using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknologisk
{
    class StringHelper
    {
        public static string FindFørsteBogstav(string txt) {
            if (txt != null && txt.Length > 0)
                return txt.Substring(0, 1);
            return "";
        }
    }

    static class StringExtension {
        public static string FindFørsteBogstav(this string txt) {
            if (txt != null && txt.Length > 0)
                return txt.Substring(0, 1);
            return "";
        }
    }
}
