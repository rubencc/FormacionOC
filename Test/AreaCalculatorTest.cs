using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Business;
using Shapes.Business.ShapeAreaCalculator;
using Shapes.Model;

namespace Test
{
    [TestClass]
    public class AreaCalculatorTest
    {
        [TestMethod]
        public void Calcular_area_de_un_cuadrado()
        {
            AreaCalculator areaCalculator = new AreaCalculator();
            Square shape = new Square(2, new SquareAreaCalculator());

            decimal expected = 4;

            decimal result = areaCalculator.Calculate(shape);

            Assert.AreEqual(expected, result, "El area deberia ser 4");
        }

        [TestMethod]
        public void Calcular_area_de_un_triangulo()
        {
            AreaCalculator areaCalculator = new AreaCalculator();
            Triangle shape = new Triangle(2, 1, new TriangleAreaCalculator());

            decimal expected = 1;

            decimal result = areaCalculator.Calculate(shape);

            Assert.AreEqual(expected, result, "El area deberia ser 4");
        }

        [TestMethod]
        public void Calcular_area_de_un_rombo()
        {
            AreaCalculator areaCalculator = new AreaCalculator();
            Rhombus shape = new Rhombus(2, new RhombusAreaCalculator());

            decimal expected = 4;

            decimal result = areaCalculator.Calculate(shape);

            Assert.AreEqual(expected, result, "El area deberia ser 4");
        }
    }
}