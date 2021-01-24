using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    //interface for shapes
    public interface IShape
    {
        string Name { get; set; }
        double CalculateArea();

    }
}
