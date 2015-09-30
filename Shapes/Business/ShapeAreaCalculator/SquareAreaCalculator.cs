using Shapes.Model;

namespace Shapes.Business.ShapeAreaCalculator
{
    public class SquareAreaCalculator : IAreaCalculator<Square>
    {

        public decimal CalcuateArea<T>(T item)
        {
            Square s = item as Square;
            return s.Size*s.Size;
        }
    }
}
