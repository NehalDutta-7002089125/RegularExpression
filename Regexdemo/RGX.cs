using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regexdemo
{
    internal class RGX
    {
        public static string a = "^[a-zA-Z]{3}_[a-zA-Z]{3}$";

        public bool b(string c)
        {
            return Regex.IsMatch(c,a);
        }
    }
}
