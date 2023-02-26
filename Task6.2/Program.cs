using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringForSearch;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Який рядок необхідно знайти?");
            stringForSearch = Console.ReadLine();
            FindAndReplaceManager.FindNext(stringForSearch);
            Console.ReadLine();
        }
    }
}
