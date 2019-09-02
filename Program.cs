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
            List<string> names = new List<string>();
            names.Add("Steve");
            names.Add("Jon");
            names.Add("Mary");
            names.Add("Julie");

            DisplayName(names);
            Console.ReadLine();


            // Print all names 2
            List<string> otherNames = new List<string>()
            {
                "Tom",
                "Dick",
                "Harry"
            };

            DisplayName(otherNames);
            Console.ReadLine();


        }

        static void DisplayName(List<string> names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            
        }
    }
}
