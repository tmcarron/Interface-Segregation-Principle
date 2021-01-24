using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    class Triangle : IHasHeightAndWidth, IShape, IHasSides
    {
        public Triangle(double height, double width)
        {
            Height = height;
            Width = width;
            Name = "Triangle";
            NumberOfSides = 3;
        }

        public double Height { get; set; }
        public double Width { get; set; }
        public string Name { get; set; }
        public int NumberOfSides { get; set; }

        public double CalculateArea()
        {
            return (Height * Width) / 2;
        }
    }
}
