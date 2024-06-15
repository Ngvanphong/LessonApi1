using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonApi1.CreateColumn
{
    public abstract class Calculation
    {
       
        public double PerimeterCal(double width, double height)
        {
            return (width + height) * 2;
        }
        public double AreaCal(double width, double height)
        {
            return width * height;
        }

    }
}
