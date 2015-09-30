using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.Business.ShapeAreaCalculator;

namespace Shapes.Model
{
    public class Square : Shape
    {
        private readonly IAreaCalculator<Square> calculator;

        public Square(decimal size, IAreaCalculator<Square> calculator)
        {
            this.size = size;
            this.calculator = calculator;
        }

        private readonly decimal size;
        public decimal Size { get { return this.size; } }

        public override decimal CalcuateArea()
        {
            return this.calculator.CalcuateArea(this);
        }
    }
}
