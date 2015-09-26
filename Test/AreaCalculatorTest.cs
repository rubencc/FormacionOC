using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Business;
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
            Square shape = new Square(2);

            decimal expected = 4;

            decimal result = areaCalculator.Calculate(shape);

            Assert.AreEqual(expected, result, "El area deberia ser 4");
        }
    }
}
