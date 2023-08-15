SELECT Products.ProductName, Categories.CategoryName
FROM Products
LEFT JOIN Products_Categories
ON Products.Id = Products_Categories.Product_Id
LEFT JOIN Categories
ON Products_Categories.Category_Id = Categories.Id