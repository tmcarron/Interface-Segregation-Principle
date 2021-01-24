using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    //interface for shapes with sides
    public interface IHasSides
    {
        int NumberOfSides { get; set; }
    }
}
