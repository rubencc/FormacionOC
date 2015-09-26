using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Model
{
    public class Rhombus
    {
        public Rhombus(decimal size)
        {
            this.size = size;
        }

        private readonly decimal size;
        public decimal Size { get { return this.size; } }
    }
}
