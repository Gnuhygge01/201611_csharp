using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknologisk
{
    public static class MyString
    {
        public static string FormatName(this string name) {
            if (name != null && name != "") {
                string res = name.Substring(0, 1).ToUpper() + name.Substring(1);
                return res;
            }
            return name;
        }
    }
}
