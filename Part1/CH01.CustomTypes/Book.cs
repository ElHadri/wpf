using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH01.CustomTypes
{
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int YearPublished { get; set; }

        public override string ToString()
        {
            return string.Format($"{Name} by {Author}\nPublished {YearPublished}");
        }
    }
}
