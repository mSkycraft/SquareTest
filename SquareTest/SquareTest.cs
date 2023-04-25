using Square;

namespace SquareTest
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void SquareCircleTest()
        {
            double R = 9;
            double expected = 254.469;
            Square.Square square = new Square.Square("Circle", new double[]{ R });
            Assert.AreEqual(expected, square.S, 0.001, "Вычисление площади проведено не корректно");
        }

        [TestMethod]
        public void SquareTriangeTest()
        {
            double x = 4;
            double y = 2;
            double z = 3;
            double expected = 2.904;
            Square.Square square = new Square.Square("triangle",new double[] { x, y, z });
            Assert.AreEqual(expected, square.S, 0.001, "Вычисление площади проведено не корректно");
        }

        [TestMethod]
        public void SquareTriangleRectangularTrueTest() {
            double x = 4;
            double y = 5;
            double z = 3;
            double expected = 1;
            string key = "rectangular";
            Square.Square square = new Square.Square("triangle", new double[] { x, y, z });
            Assert.AreEqual(expected, square.othersResult[key], 0.00001, "Вычисление прямоугольности проведено не корректно");
        }

        [TestMethod]
        public void SquareTriangleRectangularFalseTest()
        {
            double x = 3;
            double y = 5;
            double z = 3;
            double expected = 0;
            string key = "rectangular";
            Square.Square square = new Square.Square("triangle", new double[] { x, y, z });
            Assert.AreEqual(expected, square.othersResult[key], 0.00001, "Вычисление прямоугольности проведено не корректно");
        }
    }
}