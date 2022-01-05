using System;
using System.Runtime.InteropServices;

namespace ConsoleApplication
{
    internal class Program
    {
        [DllImport("NativeLibrary.dll")]
        public static extern void HelloWorld();
        static void Main(string[] args)
        {
            HelloWorld();
            Console.ReadLine();
        }
    }
}
