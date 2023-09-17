using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A5Calculator;
namespace A5Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cal cal = new Cal();
            
            Console.WriteLine("Add two numbers");

            Console.WriteLine("Result: " + cal.Add(12, 12));

            Console.WriteLine("Subtract two numbers");

            Console.WriteLine("Result: " + cal.Sub(12, 12));

            Console.WriteLine("Multiply two numbers");

            Console.WriteLine("Result: " + cal.Mul(12, 12));

            Console.WriteLine("Divide two numbers");

            Console.WriteLine("Result: " + cal.Div(12, 12));
        }
    }
}
