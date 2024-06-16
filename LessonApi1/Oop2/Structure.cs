using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonApi1.Oop2
{
    public class Structure
    {
        public int Id { set; get; }
        public virtual void Print()
        {
            Console.WriteLine("Structure");
        }

    }
}
