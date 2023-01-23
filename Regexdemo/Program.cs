using System;

namespace Regexdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RGX regex= new RGX();
            Console.WriteLine( regex.b("Sam"));
        }
    }
}
