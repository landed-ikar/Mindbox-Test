using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AreaCalcLib;

namespace AreaCalcLibTest {
    [TestClass]
    public class CircleTest {
        [TestMethod]
        public void CheckCtorParameters() {
            double r = -3;
            Assert.ThrowsException<ArgumentException>(() => { new Circle(r); });
        }
        [TestMethod]
        public void CheckInstanceArea() {
            //Arrange
            double r = 1;
            double expectedArea = Math.PI;
            Circle circtle = new Circle(r);
            //Act
            double actualArea = circtle.Area;
            //Assert
            Assert.AreEqual(expectedArea, actualArea);
        }
        [TestMethod]
        public void CheckStaticArea() {
            //Arrange
            double r = 1;
            double expectedArea = Math.PI;
            //Act
            double actualArea = Circle.GetArea(r);
            //Assert
            Assert.AreEqual(expectedArea, actualArea);
        }
        [TestMethod]
        public void CheckBaseArea() {
            //Arrange
            double r = 1;
            double expectedArea = Math.PI;
            //Act
            Shape shape = new Circle(r);
            double actualArea = shape.Area;
            //Assert
            Assert.AreEqual(expectedArea, actualArea);

        }
    }
}
