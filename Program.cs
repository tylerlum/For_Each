using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print all names 1
            new List<string>() { "Steve", "Jon", "Mary", "Julie" }
            .ForEach(n => Console.WriteLine(n));
            Console.ReadLine();

            // Print all names 2
            new List<string>() { "Tom", "Dick", "Harry" }
            .ForEach(n => Console.WriteLine(n));
            Console.ReadLine();
        }
    }
}
