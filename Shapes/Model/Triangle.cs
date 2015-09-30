using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.Business.ShapeAreaCalculator;

namespace Shapes.Model
{
    public class Triangle : Shape
    {
        private readonly IAreaCalculator<Triangle> calculator;

        public Triangle(decimal height, decimal _base, IAreaCalculator<Triangle> calculator)
        {
            this.height = height;
            this._base = _base;
            this.calculator = calculator;
        }

        private readonly decimal height;
        public decimal HeightSize { get { return this.height; } }

        private readonly decimal _base;
        public decimal BaseSize { get { return this._base; } }

        public override decimal CalcuateArea()
        {
            return this.calculator.CalcuateArea(this);
        }
    }
}
