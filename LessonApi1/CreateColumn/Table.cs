using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LessonApi1.CreateColumn
{
    public class Table : ITable, IColor
    {
        public string Name { get; set; }   
        public double Width {  get; set; }
        public double Height { get; set; }
        public string Color { get; set; }

        public double Area()
        {
            return Width * Height;
        }

        public void Print()
        {
            double area = Area();
            Console.WriteLine(area);
        }
    }
}
