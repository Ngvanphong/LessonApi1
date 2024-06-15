using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonApi1.CreateColumn
{
    public class Rectangle : Geometry
    {
        public Rectangle(double a, double b) : base(a, b)
        {
        }

        public override void PrintMoniter()
        {
            double area = AreaCal();
            Console.WriteLine($"Hinh chu nhat co dien tich = {area}");
        }
    }
}
