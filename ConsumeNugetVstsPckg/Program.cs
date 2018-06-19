using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeNugetVstsPckg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(VstsPackage.Class1.Get());
            Console.ReadLine();
        }
    }
}
