using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp6
{
    class Program
    {
        struct Book
        {
            public string author;
            public string title;
            public int shelf;
            public bool checkedout;
            public bool isDeleted;
        }

        static void Main(string[] args)
        {
            Book[] library = new Book[50];
            int libraryCount = 0;
            int libraryIdx = 0;

            string cmd = "";
            string lCmd = "";
            Example1 eg = new Example1();
            while (cmd.ToLower() != "exit")
            {
                cmd = eg.Ask("Awaiting input?");
                lCmd = cmd.ToLower();
                if(lCmd=="add")
                {
                    Book tmp = new Book();
                    tmp.author = eg.Ask("Please enter Author >");
                    tmp.title = eg.Ask("Please enter Title >");
                    tmp.checkedout = false;
                    int.TryParse(eg.Ask("Please enter Current Shelf >"), out tmp.shelf);
                    library[libraryCount] = tmp;
                    libraryCount++;
                }
                if (lCmd == "list")
                {
                    for (int idx = 0; idx < libraryCount; idx++)
                    {
                        Book book = library[idx];
                        if (book.isDeleted == true)
                        {
                            library[idx] = library[idx - 1];
                            libraryCount--;
                        }
                        eg.MyPrinter($"Book Index = {idx} : {book.author},{book.title},{book.shelf},{book.checkedout}");
                    }
                }
                if (lCmd == "delete")
                {
                    int chosenBook = 0;
                    int.TryParse(eg.Ask("What number book in the list would you like to delete?"), out chosenBook);
                    for (int reset = 1; reset < libraryCount; reset++)
                    {
                        library[chosenBook] = library[chosenBook + 1];
                        chosenBook++;
                    }
                    
                    libraryCount--;
                }
                if (lCmd == "checkout")
                {
                    int check = 0;
                    int.TryParse(eg.Ask("Which book would you like to check out?"), out check);
                    library[check].checkedout = true;
                }
                if (lCmd == "return")
                {
                    int check = 0;
                    int.TryParse(eg.Ask("Which book would you like to check out?"), out check);
                    library[check].checkedout = false;
                }
                //implement delete book from library
                //implement checkout book from library (set the checked out bool to true
                //implement return book
            }
            eg.MyPrinter("End of execution");
           
            Console.ReadKey();
        }
    }
}
