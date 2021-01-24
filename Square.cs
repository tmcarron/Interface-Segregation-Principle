using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    public class Square : IIsEquilateral, IShape, IHasSides
    {
        public Square(double sideLength)
        {
            Name = "Square";
            NumberOfSides = 4;
            SideLength = sideLength;

        }
        public string Name { get; set; }
        public double SideLength { get; set; }
        public int NumberOfSides { get; set; }

        public double CalculateArea()
        {
            return SideLength * SideLength;
        }
    }
}
