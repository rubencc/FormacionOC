using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.Model;

namespace Shapes.Business
{
    public class AreaCalculator
    {
        public decimal Calculate(Square shape)
        {
            return shape.Size*shape.Size;
        }
    }
}
