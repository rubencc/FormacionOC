using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.Business.ShapeAreaCalculator;

namespace Shapes.Model
{
    public class Rhombus : Shape
    {
        private IAreaCalculator<Rhombus> calculator;

        public Rhombus(decimal size, IAreaCalculator<Rhombus> calculator)
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
