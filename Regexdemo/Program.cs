using System;

namespace Regexdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RGX regex= new RGX();
            Console.WriteLine( regex.b("Nehal.Dutta09@bridgelabz.com"));
            Console.WriteLine(regex.check("8638451211"));
            Console.WriteLine(regex.check2("P@$$w0rD@2611"));
        }
    }
}
