using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    interface Figure
    {
        double GetArea();
        bool IsValid();
    }

    class Rectangle : Figure
    {
        double x;
        double y;

        public Rectangle(double x,double y)
        {
            this.x = x;
            this.y = y;
        }

       public double GetArea()
        {
            if (this.IsValid())
                return x * y;
            else
                return -1;

        }

        public bool IsValid()
        {
            if (x > 0 && y > 0)
                return true;
            else
                return false;
        }
    }

    class Triangle : Figure
    {
        double a;
        double b;
        double c;

        public Triangle(double a, double b,double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double GetArea()
        {
            if (this.IsValid())
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else return -1;
        }

        public bool IsValid()
        {
            if (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a) 
                return true;
            else
                return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
