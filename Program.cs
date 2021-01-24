using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this program is meant to demonstrate my understanding of the Interface Segregation Principle.");
            Console.WriteLine("Please enter 1 for Circle, 2 for Square, or 3 for Triangle. ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if(userInput == 1)
            {
                Console.WriteLine("Please enter a radius");
                Circle circle = new Circle(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine($"The area of this circle is {circle.CalculateArea()}");
            }
            if(userInput == 2)
            {
                Console.WriteLine("Please enter a side length.");
                Square square = new Square(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine($"The area of this square is {square.CalculateArea()}");
            }
            if(userInput == 3)
            {
                Console.WriteLine("Please enter a height");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter a width");
                double width = Convert.ToDouble(Console.ReadLine());
                Triangle triangle = new Triangle(height, width);
                Console.WriteLine($"The area of this triangle is {triangle.CalculateArea()}");
            }
        }
    }
}
