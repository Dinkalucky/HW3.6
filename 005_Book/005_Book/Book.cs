using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _005_Book
{
    class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Пошук рядка : " + str);
        }

        public static class Notes
        {
            static string[] allNotes = new string[5];
            public static string[] SavedNotes(string note)
            {
                
                for (int i = 0; i < allNotes.Length; i++)
                {
                    if (allNotes[i] == null)
                    {
                        allNotes[i] = note;
                        break;
                    }

                    if (i == allNotes.Length - 1 && allNotes[i] != null)
                    {
                        Console.WriteLine("Записна книжка переповнена");
                    }

                }
                return allNotes;
            }
        }
    }
}
