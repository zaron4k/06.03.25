using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Point
    {
        
        private int x;
        private int y;

        
        public double X
        {
            get { return x; }
            set { x = (int)value; }
        }

        public double Y
        {
            get { return y; }
            set { y = (int)value; }
        }

        
        public Point(double x, double y)
        {
            x = 0;
            y = 0;
        }

      
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Print()
        {
            Console.WriteLine($"({x},{y})"); 
        }

    }

}

