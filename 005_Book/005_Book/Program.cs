using System;
using System.Text;


namespace _005_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            string note;
            string[] allNotes;
            Console.OutputEncoding = Encoding.UTF8;
            
            while (true)
            {
                Console.WriteLine("Що ви бажаєте занотувати?");
                note = Console.ReadLine();
                allNotes = Book.Notes.SavedNotes(note);
                Console.WriteLine("Ваші нотатки:");
                foreach (var item in allNotes)
                {
                    if(item!=null)
                    Console.WriteLine(item);
                }

                Console.WriteLine(new string('-',20));
            }
        }
    }
}
