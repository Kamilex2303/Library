using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class LibraryApp
    {
        public static void Main(String[] args)
        {
            LibraryControl libControl = new LibraryControl();
            libControl.controlLoop();
        }
    }
}
