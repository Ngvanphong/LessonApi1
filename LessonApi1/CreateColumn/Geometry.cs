using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonApi1.CreateColumn
{
    public abstract  class Geometry
    {

        public Geometry(double a, double b)
        {
            (A, B) = (a, b);
        }
        public double A { set; get; }
        public double B { set; get; }

        public abstract void PrintMoniter();

        public double AreaCal()
        {
            return A * B;
        }
    }
}
