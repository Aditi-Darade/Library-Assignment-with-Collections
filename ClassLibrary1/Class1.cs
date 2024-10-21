using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    interface ILoanable
    {
        int LoanPeriod { get; set; } //property
        string Borrower { get; set; } //property
        void Borrow(int loanPeriod, string borrower, string title); //method
        void Return(string title); //method
    }
    interface IPrintable
    {
        void Print(); //method
    }

    public class Item
    {
        private string itemType;
        public string ItemType { get; set; }
    }   
    //-------------------------------------------------------------------------------------------------
    public class Book : Item, ILoanable, IPrintable
    {
        private int loanPeriod;
        public int LoanPeriod
        {
            set
            {
                if (value < 21)
                {
                    loanPeriod = value;
                }
                else
                {
                    loanPeriod = value;
                    Console.WriteLine("!!! The loanable time period for a book is 21 days, you cannot loan the book for more than 21 days.");
                }
            }
            get
            {
                return loanPeriod;
            }
        }
        public string Borrower { get; set; }
        public void Borrow(int loanPeriod, string borrower, string title) //method 
        {
            LoanPeriod = loanPeriod;
            Borrower = borrower;
            Title = title;
            Console.WriteLine("~" + Title + " by " + Author + " has been borrowed by " + Borrower + " for " + LoanPeriod + " days.");

        }
        public void Return(string title) //method
        {
            if (title == Title)
            {
                if (LoanPeriod > 21)
                {
                    Console.WriteLine("!!! You have returned this book after loanable time period which was 21 days. Please pay a book kept overtime fee. ");
                }
                Console.WriteLine("~" + Title + " by " + Author + " has been returned by " + Borrower + " after " + LoanPeriod + " days.");
                LoanPeriod = 0;
                Borrower = "";
            }
   
        }
        public string Author;
        public string Title;
        public int ISBN;


        public Book(string borrower, string author, string title, int iSBN)
        {
            Borrower = borrower;
            Author = author;
            Title = title;
            ISBN = iSBN;
            ItemType = "Book";
        }

        public void Print()
        {
            System.Console.WriteLine("Borrower: " + Borrower + ", Author: " + Author + ", Title: " + Title + ", ISBN: " + ISBN);
        }
    }
    //-------------------------------------------------------------------------------------------------
    
    public class DVD : Item, ILoanable, IPrintable
    {
        private int loanPeriod;
        public int LoanPeriod
        {
            set
            {
                if (value < 7)
                {
                    loanPeriod = value;
                }
                else
                {
                    loanPeriod = value;
                    Console.WriteLine("!!! The loanable time period for a DVD is 7 days, you cannot loan the book for more than 7 days.");
                }
            }
            get
            {
                return loanPeriod;
            }
        }
        public string Borrower { get; set; }
        public void Borrow(int loanPeriod, string borrower, string title) //method 
        {
            LoanPeriod = loanPeriod;
            Borrower = borrower;
            Title = title;
            Console.WriteLine("~" + Title + " by " + Director + " has been borrowed by " + Borrower + " for " + LoanPeriod + " days.");

        }
        public void Return(string title) //method
        {
            if (title == Title)
            {
                if (LoanPeriod > 7)
                {
                    Console.WriteLine("!!! You have returned this DVD after loanable time period which was 7 days. Please pay a book kept overtime fee. ");
                }
                Console.WriteLine("~" + Title + " by " + Director + " has been returned by " + Borrower + " after " + LoanPeriod + " days.");
                LoanPeriod = 0;
                Borrower = "";
            }

        }
        public string Director;
        public string Title;
        public int LengthInMinutes;


        public DVD(string borrower, string director, string title, int lengthInMinutes)
        {
            Borrower = borrower;
            Director = director;
            Title = title;
            LengthInMinutes = lengthInMinutes;
            ItemType = "DVD";

        }

        public void Print()
        {
            System.Console.WriteLine("Borrower: " + Borrower + ", Director: " + Director + ", Title: " + Title + ", LengthInMinutes: " + LengthInMinutes);
        }

    }
    //-------------------------------------------------------------------------------------------------
    public class CD : Item, ILoanable, IPrintable
    {
        private int loanPeriod;
        public int LoanPeriod
        {
            set
            {
                if (value < 14)
                {
                    loanPeriod = value;
                }
                else
                {
                    loanPeriod = value;
                    Console.WriteLine("!!! The loanable time period for a CD is 14 days, you cannot loan the book for more than 14 days.");
                }
            }
            get
            {
                return loanPeriod;
            }
        }
        public string Borrower { get; set; }
        public void Borrow(int loanPeriod, string borrower, string title) //method 
        {
            LoanPeriod = loanPeriod;
            Borrower = borrower;
            Title = title;
            Console.WriteLine("~" + Title + " by " + Artist + " has been borrowed by " + Borrower + " for " + LoanPeriod + " days.");

        }
        public void Return(string title) //method
        {
            if (title == Title)
            {
                if (LoanPeriod > 14)
                {
                    Console.WriteLine("!!! You have returned this CD after loanable time period which was 14 days. Please pay a book kept overtime fee. ");
                }
                Console.WriteLine("~" + Title + " by " + Artist + " has been returned by " + Borrower + " after " + LoanPeriod + " days.");
                LoanPeriod = 0;
                Borrower = "";
            }

        }
        public string Artist;
        public string Title;
        public int NumberOfTracks;


        public CD(string borrower, string artist, string title, int numberOfTracks)
        {
            Borrower = borrower;
            Artist = artist;
            Title = title;
            NumberOfTracks = numberOfTracks;
            ItemType = "CD";
        }

        public void Print()
        {
            System.Console.WriteLine("Borrower: " + Borrower + ", Artist: " + Artist + ", Title: " + Title + ", NumberOfTracks: " + NumberOfTracks);
        }

    }
    //-------------------------------------------------------------------------------------------------
    
    public class Library
    {
        List<Item> Items = new List<Item>();
        public void AddItem(Item itemToAdd)
        {
            Items.Add(itemToAdd);
        }
        public void RemoveItem(Item itemToRemove, string title)
        {
            foreach (Item item in Items)
            {
                if (item.ItemType == "Book")
                {
                    Book tempBook = (Book)item;
                    if (tempBook.Title == title)
                    {
                        Items.Remove(tempBook);
                        break;
                    }

                }
            }
            
            foreach (Item item in Items)
            {
                if (item.ItemType == "DVD")
                {
                    DVD tempDVD = (DVD)item;
                    if (tempDVD.Title == title)
                    {
                        Items.Remove(tempDVD);
                        break;
                    }

                }
            }
            foreach (Item item in Items)
            {
                if (item.ItemType == "CD")
                {
                    CD tempCD = (CD)item;
                    if (tempCD.Title == title)
                    {
                        Items.Remove(tempCD);
                        break;
                    }

                }
            }
            
        }

        public void PrintLibrary()
        {
            Console.WriteLine("\nLibrary Items: ");
            foreach (Item item in Items)
            {
                if (item.ItemType == "Book")
                {
                    Book tempBook = (Book)item;
                    Console.WriteLine("Borrower: " + tempBook.Borrower + ", Author: " + tempBook.Author + ", Title: " + tempBook.Title + ", ISBN: " + tempBook.ISBN);
                }
            }
            
            foreach (Item item in Items)
            {
                if (item.ItemType == "DVD")
                {
                    DVD tempDVD = (DVD)item;
                    Console.WriteLine("Borrower: " + tempDVD.Borrower + ", Director: " + tempDVD.Director + ", Title: " + tempDVD.Title + ", Length In Minutes: " + tempDVD.LengthInMinutes);
                }
            }
            foreach (Item item in Items)
            {
                if (item.ItemType == "CD")
                {
                    CD tempCD = (CD)item;
                    Console.WriteLine("Borrower: " + tempCD.Borrower + ", Artist: " + tempCD.Artist + ", Title: " + tempCD.Title + ", Number Of Tracks: " + tempCD.NumberOfTracks);
                }
            }
            
        }


    }
}
