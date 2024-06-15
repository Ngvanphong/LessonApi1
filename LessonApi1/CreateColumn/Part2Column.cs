using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonApi1.CreateColumn
{
    public partial class Column 
    {
        public long Id { get; set; }    
        public double Height {  get; set; }

        public partial void Show(long id, double height)
        {
            
        }

    }
   
}
