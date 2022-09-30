(select Products.ProductName, Categories.CategoryName
from Products
left outer join ProductCategory on Products.ProductID = ProductCategory.ProductID
left outer join Categories on Categories.CategoryID = ProductCategory.CategoryID)
union
(select Null, Categories.CategoryName
from Categories
left outer join ProductCategory on Categories.CategoryID = ProductCategory.CategoryID
Where ProductCategory.ProductID is null)
