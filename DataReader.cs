using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class DataReader
    {
        public Book readAndCreateBook()
        {
            Console.Write("Title : ");
            String title = Console.ReadLine();
            Console.Write("Pages : ");
            int pages = int.Parse(Console.ReadLine());

            return new Book(title, pages);
        }

    }
}
