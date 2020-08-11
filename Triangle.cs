using System;
using System.Collections.Generic;
using System.Text;

namespace C_task_04
{
    class Triangle
    {
        double a;
        double b;
        double c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool PossibleTriangle(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a) return true;
            else return false;
        }

        public double PerimeterTriangle(double a, double b, double c)
        {
            return a + b + c;
        }

        public double SquareTriangle(double a, double b, double c)
        {
            double p = PerimeterTriangle(a, b, c) / 2;
            return Math.Pow(p*(p-a)*(p-b)*(p-c),0.5);
        }

    }
}
