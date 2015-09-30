using Shapes.Model;

namespace Shapes.Business.ShapeAreaCalculator
{
    public class RhombusAreaCalculator : IAreaCalculator<Rhombus>
    {
        public decimal CalcuateArea<T>(T item)
        {
            Rhombus r = item as Rhombus;
            return r.Size*r.Size;
        }
    }
}
