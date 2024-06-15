using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonApi1.CreateColumn
{
    public  class Element 
    {
        public long Id { set; get; }
        public string Name { set; get; } 
        public double Volume { set; get; }

        public double Width { set; get; }
        public double Length { set; get; }

        public void PrintMoniter()
        {
            Console.WriteLine($"This is: {Name} - Id= {Id}- Volume= {Volume}");
        }
    }
}
