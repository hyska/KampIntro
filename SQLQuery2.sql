--Select
--ANSII
select ContactName,CompanyName,City from Customers

Select * from Customers where City='London'

--case insensitive
select * from Products Where CategoryID=1 or CategoryID=3

select * from Products Where CategoryID=1 and UnitPrice>=10

select * from Products order by UnitPrice asc --ascending artan

select * from Products order by UnitPrice desc --descending düşen

select count(*)  Adet from Products

select CategoryID,count(*) from Products where UnitPrice>20
group by CategoryID having count(*)<10

--inner join sadece iki tabloda eşleşen verileri getirir
--eşleşmeyeni getirmez
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10

--left join solda olup sağdaki tabloda olmayan ürünleri de getirir
select * from Products p inner join [Order Details] od
on p.ProductID=od.ProductID
inner join Orders o
on o.OrderID=od.OrderID

select * from Customers c left join Orders o
on c.CustomerID=o.CustomerID
where o.CustomerID is null

--DTO data transformation object