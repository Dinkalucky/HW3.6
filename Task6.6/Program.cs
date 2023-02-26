using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть перше число:");
            Int32.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Введіть друге число:");
            Int32.TryParse(Console.ReadLine(), out b);

            Console.WriteLine($"{a} + {b} = {Calculator.Sum(a,b)}");
            Console.WriteLine($"{a} - {b} = {Calculator.Sub(a, b)}");
            Console.WriteLine($"{a} * {b} = {Calculator.Mul(a, b)}");
            Console.WriteLine($"{a} / {b} = {Calculator.Div(a, b)}");
            Console.WriteLine($"{a} ^ {b} = {Calculator.Pow(a, b)}");
            Console.WriteLine($"{a} % {b} = {Calculator.Rest(a, b)}");

            Console.ReadLine();
        }
    }
}
