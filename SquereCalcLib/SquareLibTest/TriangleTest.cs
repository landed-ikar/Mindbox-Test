using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SquareCalcLib;
using System.Collections.Generic;

namespace SquareLibTest {
    [TestClass]
    public class TriangleTest {
        [TestMethod]
        public void CheckCtorParameters() {
            List<double[]> values = new List<double[]>() {
                new double[3] {-3, 4, 5},
                new double[3] {3, -4, 5 },
                new double[3] {3, 4, -5 },
                new double[3] {100, 4, 5 },
                new double[3] {3, 100, 5 },
                new double[3] {3, 4, 100 },
                new double[3] {0, 4, 5 },
                new double[3] {3, 0, 5 },
                new double[3] {3, 4, 0 },
            };
            foreach(double[] array in values) {
                Assert.ThrowsException<ArgumentException>(
                    () => { new Triangle(array[0], array[1], array[2]); },
                    $"Test failed for parameters: {array}");
            }
        }
        [TestMethod]
        public void CheckInstanceSquare() {
            //Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expectedSquare = 6;
            Triangle triangle = new Triangle(a, b, c);
            //Act
            double actualSquare = triangle.Square;
            //Assert
            Assert.AreEqual(expectedSquare, actualSquare);
        }
        [TestMethod]
        public void CheckInstanceRectangularTrue() {
            //Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            bool expectedIsRect = true;
            Triangle triangle = new Triangle(a, b, c);
            //Act
            bool actualIsRect = triangle.IsRectangular;
            //Assert
            Assert.AreEqual(expectedIsRect, actualIsRect);
        }
        [TestMethod]
        public void CheckInstanceRectangularFalse() {
            //Arrange
            double a = 3;
            double b = 4;
            double c = 6;
            bool expectedIsRect = false;
            Triangle triangle = new Triangle(a, b, c);
            //Act
            bool actualIsRect = triangle.IsRectangular;
            //Assert
            Assert.AreEqual(expectedIsRect, actualIsRect);
        }
        [TestMethod]
        public void CheckStaticSquare() {
            //Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expectedSquare = 6;
            //Act
            double actualSquare = Triangle.GetSquare(a, b, c);
            //Assert
            Assert.AreEqual(expectedSquare, actualSquare);
        }
        [TestMethod]
        public void CheckStaticSquareParameters() {
            List<double[]> values = new List<double[]>() {
                new double[3] {-3, 4, 5},
                new double[3] {3, -4, 5 },
                new double[3] {3, 4, -5 },
                new double[3] {100, 4, 5 },
                new double[3] {3, 100, 5 },
                new double[3] {3, 4, 100 },
                new double[3] {0, 4, 5 },
                new double[3] {3, 0, 5 },
                new double[3] {3, 4, 0 },
            };
            foreach(double[] array in values){
                Assert.ThrowsException<ArgumentException>(
                    () => { Triangle.GetSquare(array[0], array[1], array[2]); },
                    $"Test failed for parameters: {array}");
            }
        }
        [TestMethod]
        public void CheckStaticRectangularTrue() {
            //Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            bool expectedIsRect = true;
            //Act
            bool actualIsRect = Triangle.ChaeckIsRectangular(a, b, c);
            //Assert
            Assert.AreEqual(expectedIsRect, actualIsRect);
        }
        [TestMethod]
        public void CheckStaticRectangularFalse() {
            //Arrange
            double a = 3;
            double b = 4;
            double c = 6;
            bool expectedIsRect = false;
            //Act
            bool actualIsRect = Triangle.ChaeckIsRectangular(a, b, c);
            //Assert
            Assert.AreEqual(expectedIsRect, actualIsRect);

        }
        [TestMethod]
        public void CheckBaseSquare() {
            //Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expectedSquare = 6;
            Shape shape = new Triangle(a, b, c);
            //Act
            double actualSquare = shape.Square;
            //Assert
            Assert.AreEqual(expectedSquare, actualSquare);

        }
    }
}
