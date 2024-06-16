using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonApi1.Oop2
{
    public class Rebar : Structure
    {

        public static DaysEnum Today = DaysEnum.Monday;
        public double Length { set; get; }
        public double Desity { set; get; }

        public double Raidus { set; get; }  
        public override void Print()
        {
            Console.WriteLine("Rebar");
        }

        public void WeightVolCal(out double weight , out double volume)
        {
            volume = Math.PI * Math.Pow(Raidus, 2);
            weight = volume * Length * Desity;
        }

        public double Subtract(ref double a, double b)
        {
            double result = a-b;
            a = 16;
            return result;
        }


    }
}
