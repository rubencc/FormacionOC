using Shapes.Model;

namespace Shapes.Business.ShapeAreaCalculator
{
    public class TriangleAreaCalculator : IAreaCalculator<Triangle>
    {
        public decimal CalcuateArea<T>(T item)
        {
            Triangle t = item as Triangle;
            return (t.BaseSize * t.HeightSize) / 2;
        }
    }
}
