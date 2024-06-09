using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LessonApi1
{
    public class AirDuct
    {
        public AirDuct()
        {
            
        }
        public AirDuct(double width, double height, string material )
        {
            this.Width = width;
            Height = height;
            Material = material;
        }

        public AirDuct(string a, string b)
        {
            Material = a;
        }
        public double Width { set; get; }
        
        public double Height { set;get; } 

        public  string Material { set;  get; }

        public double AreaCalculation()
        {
            double result= Width *Height;
            return result;
        }
        public double VolumnCal(double length=10)
        {
            double result = Width * Height * length;
            return result;
        }
        public static double VolumnCal(int lengthInt = 1)
        {
            return lengthInt;
        }


        public int Calc(int a, int b, int c = 10, bool add=true)
        {
            if (add)
            {
                int total= a+b+c;
                return total;
            }
            else
            {
                int multi = a * b * c;
                return multi;
            }
        }

        public void Print(double result)
        {
            Console.WriteLine(result);
            result = 10;
            return;
            Console.WriteLine("Conooooddd"); ;
        }
        
        

    }
}
