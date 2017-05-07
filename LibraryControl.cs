using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class LibraryControl
    {
        

        private DataReader dataReader;
        private Library library;

        public LibraryControl()
        {
            dataReader = new DataReader();
            library = new Library();
        }

        public void controlLoop()
        {

            printOptions();
            int options = int.Parse(Console.ReadLine());
            while (options != 0)
            {
                switch (options)
                {
                    case 1:
                        addNewBook();
                        break;
                    case 2:
                        printAllBooks();
                        break;
                    default:
                        Console.WriteLine("Nie ma takiej opcji");
                        break;
                    
                

                }
                printOptions();
                options = int.Parse(Console.ReadLine());

            }
        }

        private void printOptions()
        {
            Console.WriteLine("Wybierz opcje : ");
            Console.WriteLine("0-wyjscie z programu ");
            Console.WriteLine("1-dodanie nowej książki ");
            Console.WriteLine("2-wyswietlenie wszystkich ksiazek ");
        }

        private void addNewBook()
        {
            Book book = dataReader.readAndCreateBook();
            library.addBook(book);
        }
        private void printAllBooks()
        {
            library.printBooks();
        }

    }
}
