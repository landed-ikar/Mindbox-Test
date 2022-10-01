using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AreaCalcLib;
using System.Collections.Generic;

namespace AreaCalcLibTest {
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
        public void CheckInstanceArea() {
            //Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expectedArea = 6;
            Triangle triangle = new Triangle(a, b, c);
            //Act
            double actualArea = triangle.Area;
            //Assert
            Assert.AreEqual(expectedArea, actualArea);
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
        public void CheckStaticArea() {
            //Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expectedArea = 6;
            //Act
            double actualArea = Triangle.GetArea(a, b, c);
            //Assert
            Assert.AreEqual(expectedArea, actualArea);
        }
        [TestMethod]
        public void CheckStaticAreaParameters() {
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
                    () => { Triangle.GetArea(array[0], array[1], array[2]); },
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
            bool actualIsRect = Triangle.CheckIsRectangular(a, b, c);
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
            bool actualIsRect = Triangle.CheckIsRectangular(a, b, c);
            //Assert
            Assert.AreEqual(expectedIsRect, actualIsRect);

        }
        [TestMethod]
        public void CheckBaseArea() {
            //Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expectedArea = 6;
            Shape shape = new Triangle(a, b, c);
            //Act
            double actualArea = shape.Area;
            //Assert
            Assert.AreEqual(expectedArea, actualArea);

        }
    }
}
