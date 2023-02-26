using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._4
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 4, 1, 8, 6 };
            ArrayExtension.SortArrayExt(array);
            Console.ReadKey();
        }
    }
}
