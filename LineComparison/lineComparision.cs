using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    internal class Line
    {
        public static void Start() { 
            //For Sirst line co-ordinate (x1,y1) and (x2,y2)
        Console.WriteLine("Input the value of x1 in x co-ordinate");
            int x1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the value of y1 co-ordinate");
            int y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the value of x2 co-ordinate");
            int x2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the value of y2 co-ordinate");
            int y2 = Convert.ToInt32(Console.ReadLine());

            //For second line co-ordinate (x3,y3) and (x4,y4)
            Console.WriteLine("Input the value of x3 in x co-ordinate");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the value of y3 co-ordinate");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the value of x4 co-ordinate");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the value of y4 co-ordinate");
            int y4 = Convert.ToInt32(Console.ReadLine());

            //Calculate length line 1
            int lengthOfline1 = (int)Math.Sqrt((x2*x2 - x1*x1) + (y2*y2 - y1*y1));
            Console.WriteLine("Lenth of line is: "+ lengthOfline1);

            //Calculate length of line 2
            int lengthOfline2 = (int)Math.Sqrt((x2*x2 - x1*x1) + (y2*y2 - y1*y1));
            Console.WriteLine("Lenth of line is: " + lengthOfline2);

            if (lengthOfline1 == lengthOfline2)
            {
                Console.WriteLine("Equal");
            }
            else if
                (lengthOfline1 < lengthOfline2)
            {
                Console.WriteLine("L1 Lesser than L2");
            }
            else
                Console.WriteLine("L1 greater than L2");

            
                    Console.ReadKey();
        }  
    }
}