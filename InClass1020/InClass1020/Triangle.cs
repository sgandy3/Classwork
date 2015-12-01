using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass1020
{
    class Triangle
    {
        private double side1;
        private double side2;
        private double angle;


       
        public double getArea (double side1,double side2, double angle)
        {
            angle = Math.Sin(angle);
            double triangleArea = .5 *(side1 * side2) * (angle);

            return triangleArea;
            
        }

    }
}
