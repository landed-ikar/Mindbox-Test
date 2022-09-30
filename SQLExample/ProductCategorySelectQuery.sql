         select Products.ProductName, Categories.CategoryName
           from Products
left outer join ProductCategory 
             on Products.ProductID = ProductCategory.ProductID
left outer join Categories 
             on Categories.CategoryID = ProductCategory.CategoryID
