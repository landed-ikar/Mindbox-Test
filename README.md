# Area Calculation Library - Test project for Mindbox


This sample demonstrates how to create a simple area calculation utility library with unit tests.
Also it includes the answer to the SQL task.
## AreaCalcLib Project
<!-- default file list -->
*Files to look at*:

* [Shape.cs](./AreaCalcLib/AreaCalcLib/Shape.cs)
<!-- default file list end -->
This project contains the main logic of the area calculation library. It includes three classes:
#### class Shape
It is a base class for all shapes currently supported by this library. It contains a single abstract property **Area** that returns a area of the current instance of the shape class.

#### class Triangle
It is a descendant of the Shape class that represent a triangle. It contains the following members:
* **double Area** - returns a area of the current instance of the triangle. Caches calculation result internally. 
*  **double A, B, C** - returns the length of the A, B and C side of the triangle.
* **double GetArea (double a, double b, double c, )** - static method that returns a area of a triangle by its sides. Use this method if you need to calculate a triangle's area single time without creating the shape instance.

#### class Circle
It is a descendant of the Shape class that represent a circle. It contains the following members:
* **double Area** - returns a area of the current instance of the circle. Caches calculation result internally. 
*  **double Radius** - returns the current radius of the circle.
* **double GetArea (double radius)** - static method that  returns a area of the circle by its radius. Use this method if you need to calculate a circle's area single time without creating the shape instance.

## AreaCalcLibTest Project
<!-- default file list -->
*Files to look at*:

* [TriangleTest.cs](./AreaCalcLib/AreaCalcLibTest/TriangleTest.cs)
* [CircleTest.cs](./AreaCalcLib/AreacalcLibTest/CircleTest.cs)
<!-- default file list end -->
This project contains unit tests for the AreaCalcLib project. 

## SQL Example Folder
This folder contains two files related to the SQL task:
* [ProductCategorySelectQuery.sql](./SQLExample/ProductCategorySelectQuery.sql) - Select query that returns pairs of products and categories, even if a product does not have any category.
* [ProductCategorySelectQuery2.sql](./SQLExample/ProductCategorySelectQuery2.sql) - Select query that returns all possible combinations of products and categories even if a product does not have any category or a category does not have any product.
* mindbox_test.bak - Backup file of the test data base used for this test. Since the task does not describe how the many-to-many relation should be implemented in the database I used a junction table.
