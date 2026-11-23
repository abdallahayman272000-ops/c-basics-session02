using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Book
    {
        public string title;
        public int pages;

        public override string ToString()
        {
            return $"title is {title},pages are{pages}";
        }
    }
}
