namespace Shapes.Business.ShapeAreaCalculator
{
    public interface IAreaCalculator<T>
    {
        decimal CalcuateArea<T>(T item);
    }
}
