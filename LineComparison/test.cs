using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class LineComparision
    {
        internal int x1 = Convert.ToInt32(Console.ReadLine());
        internal int y1 = Convert.ToInt32(Console.ReadLine());
        internal int x2 = Convert.ToInt32(Console.ReadLine());
        internal int y2 = Convert.ToInt32(Console.ReadLine());

        public void LineCal()
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            
            double lengthOfline1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("Lenth of line is: " + lengthOfline1);

        }
        public void Main()
        {
            Console.WriteLine("Length of line "+ LineCal);
        }
    }
}
