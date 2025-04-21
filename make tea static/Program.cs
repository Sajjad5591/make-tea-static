using System;
using System.Collections.Generic;
using System.IO;

namespace consoleApplication3
{
    public class Program
    {
      static void maketea()
        {
            Console.WriteLine("Making tea...");
            Console.WriteLine("Boiling water...");
            Console.WriteLine("Steeping tea...");
            Console.WriteLine("Pouring tea...");
            Console.WriteLine("Adding milk and sugar...");
            Console.WriteLine("Tea is ready!");
        }

        static void Main(string[] args)
        {
           maketea();
           // Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();
        }
    }

}

