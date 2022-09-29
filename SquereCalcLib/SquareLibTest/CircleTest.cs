using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SquareCalcLib;

namespace SquareLibTest {
    [TestClass]
    public class CircleTest {
        [TestMethod]
        public void CheckCtorParameters() {
            double r = -3;
            Assert.ThrowsException<ArgumentException>(() => { new Circle(r); });
        }
        [TestMethod]
        public void CheckInstanceSquare() {
            //Arrange
            double r = 1;
            double expectedSquare = Math.PI;
            Circle circtle = new Circle(r);
            //Act
            double actualSquare = circtle.Square;
            //Assert
            Assert.AreEqual(expectedSquare, actualSquare);
        }
        [TestMethod]
        public void CheckStaticSquare() {
            //Arrange
            double r = 1;
            double expectedSquare = Math.PI;
            //Act
            double actualSquare = Circle.GetSquare(r);
            //Assert
            Assert.AreEqual(expectedSquare, actualSquare);
        }
        [TestMethod]
        public void CheckBaseSquare() {
            //Arrange
            double r = 1;
            double expectedSquare = Math.PI;
            //Act
            Shape shape = new Circle(r);
            double actualSquare = shape.Square;
            //Assert
            Assert.AreEqual(expectedSquare, actualSquare);

        }
    }
}
