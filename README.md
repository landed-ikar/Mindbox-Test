# Square Calculation Library - Test project for Mindbox


This sample demonstrates how to create a simple square calculation utility library with unit tests.
### SquareCalcLib Project
<!-- default file list -->
*Files to look at*:

* [Shape.cs](./SquereCalcLib/SquereCalcLib/Shape.cs)
<!-- default file list end -->
This project contains the main logic of the square calculation library. It includes three classes:
#### class Shape
It is a base class for all shapes currently supported by this library. It contains a single abstract property **Square** that returns a square of the current instance of the shape class.

#### class Triangle
It is a descendant of the Shape class that represent a triangle. It contains the following members:
* **double Square** - returns a square of the current instance of the triangle. Caches calculation result internally. 
*  **double A, B, C** - returns the length of the A, B and C side of the triangle.
* **double GetSquare (double a, double b, double c, )** - static method that returns a square of a triangle by its sides. Use this method if you need to calculate a triangle's square single time without creating the shape instance.

#### class Circle
It is a descendant of the Shape class that represent a circle. It contains the following members:
* **double Square** - returns a square of the current instance of the circle. Caches calculation result internally. 
*  **double Radius** - returns the current radius of the circle.
* **double GetSquare (double radius)** - static method that  returns a square of the circle by its radius. Use this method if you need to calculate a circle's square single time without creating the shape instance.

### SquareLibTest Project
<!-- default file list -->
*Files to look at*:

* [TriangleTest.cs](./SquereCalcLib/SquareLibTest/TriangleTest.cs)
* [CircleTest.cs](./SquereCalcLib/SquareLibTest/CircleTest.cs)
<!-- default file list end -->
This project contains unit tests for the SquareCalcLib project. 
