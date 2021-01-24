using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    public class Circle : IShape
    {
        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }
        public double Radius;
        public string Name { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
