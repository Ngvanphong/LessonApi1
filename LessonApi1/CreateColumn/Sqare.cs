using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonApi1.CreateColumn
{
    public class Sqare : Geometry
    {
        public Sqare(double a, double b) : base(a, b)
        {
        }

        public override void PrintMoniter()
        {
            double area = AreaCal();
            Console.WriteLine($"Hinh vuong co dien tich = {area}");
        }

    }
}
