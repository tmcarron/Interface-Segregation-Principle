using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    //interface for height and width
    public interface IHasHeightAndWidth
    {
        double Height { get; set; }
        double Width { get; set; }
    }
}
