using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Model
{
    public class Triangle
    {
        public Triangle(decimal height, decimal _base)
        {
            this.height = height;
            this._base = _base;
        }

        private readonly decimal height;
        public decimal HeightSize { get { return this.height; } }

        private readonly decimal _base;
        public decimal BaseSize { get { return this._base; } }
    }
}
