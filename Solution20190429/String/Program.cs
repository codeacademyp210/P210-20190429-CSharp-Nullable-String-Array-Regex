using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = String.Format("Year: {0}", DateTime.Now.Year);

            string name = "RAUF";
            string name2 = "RAUFasdsad";


            Console.WriteLine(name2.Substring(0, 2));

            Console.ReadLine();
        }
    }
}
