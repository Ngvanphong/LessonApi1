using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonApi1.CreateColumn
{
    public partial class Column
    {
        public string Name { get; set; }    
        public double Width { set; get; }

        public partial void Show(long id,double height);
        public void Print()
        {
            Console.WriteLine($"Name={Name}");
        }
    }
}
