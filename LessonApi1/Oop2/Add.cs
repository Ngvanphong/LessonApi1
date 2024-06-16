using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LessonApi1.Oop2
{
    public class Add<T> where T : INumber<T>
    {
        public static T AddCal(T a, T b)
        {
            return (a + b);
        }
    }
}
