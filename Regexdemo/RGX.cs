using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regexdemo
{
    internal class RGX
    {
        public static string a = "^[a-z0-9A-Z]{1,10}.[a-z0-9A-Z]{1,10}@bridgelabz.(co|in|com)$";
        public static string d = "^[0-9]{1,10}$";
        public static string password = "^[a-z0-9A-Z]{8,15}$";
        public bool b(string c)
        {
            return Regex.IsMatch(c,a);
        }
        public bool check(string e)
        {
            return Regex.IsMatch(e,d);
        }
        public bool check2(string f)
        {
            return Regex.IsMatch(f, password);
        }

    }
}
