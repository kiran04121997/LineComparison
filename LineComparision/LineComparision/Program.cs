using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            LineComparison line =new LineComparison();
            line.length_line();
            line.Comparelines();
            Console.ReadLine();
        }
    }
}
