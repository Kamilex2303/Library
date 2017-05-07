using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Library
    {



        public static readonly int maxBook = 1000;
        private  Book[] books;
        private int booksNumber=0;

        public Library()
        {
            books = new Book[maxBook];
        }
        public int getBookNumber()
        {
            return booksNumber;
        }

        public Book[] getBooks()
        {
            return books;
        }

        public void addBook(Book book)
        {
            if (booksNumber < maxBook)
            {
                books[booksNumber] = book;
                booksNumber++;
            }
            else Console.WriteLine("Nie można już dodać książki !");
        }

        public void printBooks()
        {
            if (booksNumber == 0)
                Console.WriteLine("Brak książek !");
            else
            {
                for (int i = 0; i < booksNumber; i++)
                    books[i].printInfo();
            }
        }



    }
}
