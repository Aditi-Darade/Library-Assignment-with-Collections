using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec22_Assign49_LibraryAssign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Book tempBook = null;
            tempBook = new Book("Mike", "Mark Twain", "The Adventures of Tom Sawyer", 123);
            //string borrower, string author, string title, int iSBN
            library.AddItem(tempBook);

            tempBook = new Book("John", "Robert Louis Stevenson", "Treasure Island", 456);
            library.AddItem(tempBook);
            library.PrintLibrary();

            tempBook.Borrow(25, "John", "Treasure Island");
            library.PrintLibrary();

            tempBook.Return("Treasure Island");
            library.PrintLibrary();

            library.RemoveItem(tempBook, "The Adventures of Tom Sawyer");
            library.PrintLibrary();
            
            DVD tempDVD = new DVD("Ava", "Christopher Nolan", "Interstellar", 95);
            library.AddItem(tempDVD);
            tempDVD = new DVD("Sarah", "Alex Garland", "Civil War", 92);
            library.AddItem(tempDVD);

            CD tempCD = new CD("Mary", "Gracie Abrams", "Good Riddance", 75);
            library.AddItem(tempCD);
            tempCD = new CD("Josh", "SZA", "SOS", 90);
            library.AddItem(tempCD);
            library.PrintLibrary();

            library.RemoveItem(tempCD, "Good Riddance");
            library.PrintLibrary();

            tempCD.Borrow(23, "Josh", "SOS");
            library.PrintLibrary();


            tempCD.Return("SOS");
            library.PrintLibrary();

            Console.ReadKey();
        }

    }
}
