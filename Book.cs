using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Book
    {
        private String title;
        private int pages;

        public Book(String bookTitle, int bookPages)
        {
            this.title = bookTitle;
            this.pages = bookPages;
        }

        public String getTitle()
        {
            return title;
        }

        public void setTitle(String title)
        {
            this.title = title;
        }

        public int getPages()
        {
            return pages;
        }

        public void setPages(int pages)
        {
            this.pages = pages;
        }

        public void printInfo()
        {
            String info = (getTitle() + "; " + getPages());
            Console.WriteLine(info);
        }
    }
}
