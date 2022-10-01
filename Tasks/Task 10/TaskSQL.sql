use AdventureWorks2019
go
--1 - 1009 rows
select FirstName,LastName from Person.Person WHERE Title is not null

--2 - 7182 rows
select FirstName,LastName from Person.Person WHERE FirstName like '%a%' and LastName like '%a%'

--3 - 11445 rows
Select crc.CurrencyCode,c.Name
from Sales.Currency c,Sales.CountryRegionCurrency crc

--4 - 17 rows affected
create schema HR
go
select * into HR.Dept from HumanResources.Department

--5 - 6 rows
create table studetails
(
SNo int identity(1,1),
FirstName Varchar(50),
LastName Varchar(50),
DateofJoining date,
Department Varchar(30)
)
insert into studetails values('Dev','Swamy','04/16/2008','EEE')
insert into studetails values('Jaya','Kanth','04/14/2006','EEE')
insert into studetails values('Ajay','Joseph','05/12/2007','VisCom')
insert into studetails values('Samuel','Ram','04/16/2003','CSE')
insert into studetails values('Krishna','K','03/18/2005','IT')
insert into studetails values('Dhanush','S','06/15/2009','IT')

select * from studetails
 
--6 - 0 rows
Select BEAdd.BusinessEntityID,BEAdd.AddressTypeID
from Person.BusinessEntityAddress BEAdd
inner join HumanResources.department Dept
on Dept.ModifiedDate=BEAdd.ModifiedDate

--7 - 7 rows
select  distinct GroupName from HumanResources.Department

--8 - 109 rows
Select  PCH.StandardCost,sum(PROD.ListPrice+PROD.StandardCost) as SumOfListPrice_SC
from Production.ProductCostHistory PCH
join Production.Product PROD
on PROD.StandardCost=PCH.StandardCost group by PCH.StandardCost

--9 - 296 rows
select DATEDIFF(YEAR,StartDate,EndDate) as YearsOnRole
from
HumanResources.EmployeeDepartmentHistory
 

--10 - 142 rows
select Sum(SalesQuota+5000) as tot 
from Sales.SalesPersonQuotaHistory 
where SalesQuota>100000 group by SalesQuota order by SalesQuota asc 

--11 - 1 row
select max(TaxRate) as MAX_TaxRate from Sales.SalesTaxRate

--12 - 296 rows

select DepartmentID,Emp.BusinessEntityID,ShiftID,BirthDate,FLOOR(DATEDIFF(DAY, BirthDate, GETDATE()) / 365.25) AS AGE
FROM HumanResources.Employee Emp 
JOIN HumanResources.EmployeeDepartmentHistory EDH ON EDH.BusinessEntityID = Emp.BusinessEntityID

--13 - commands completed successfully
create view HumanResources.Name_age
as
select DepartmentID,E.BusinessEntityID,ShiftID,BirthDate,FLOOR(DATEDIFF(DAY, BirthDate, GETDATE()) / 365.25) AS AGE
FROM HumanResources.Employee E 
JOIN HumanResources.EmployeeDepartmentHistory EDH ON EDH.BusinessEntityID = E.BusinessEntityID


--15 - 16 rows
select Dep.DepartmentID,MAX(EPH.Rate)Rate from HumanResources.Department Dep
JOIN HumanResources.EmployeeDepartmentHistory EDH ON EDH.DepartmentID = Dep.DepartmentID
JOIN HumanResources.EmployeePayHistory EPH ON EPH.BusinessEntityID =EDH.BusinessEntityID
GROUP BY Dep.DepartmentID ORDER BY Dep.DepartmentID

--16 - 1009 rows
select FirstName,MiddleName,Title,AddressTypeID,P.BusinessEntityID
from person.person P
LEFT JOIN person.BusinessEntityAddress BEA ON p.BusinessEntityID =BEA.BusinessEntityID
WHERE P.Title IS NOT NULL


--17 - 110 rows
select ProductID,LocationID,Shelf
from Production.ProductInventory where (ProductID between 300 and 350) and (LocationID =50) or (Shelf='E')

--18 - 1069 rows
select PInv.LocationID,Shelf,Name
from Production.ProductInventory PInv 
join Production.Location PLoc
on 
PInv.LocationID=PLoc.LocationID

--19 - 19614 rows
select AddressID,AddressLine1,AddressLine2,stpro.StateProvinceID,StateProvinceCode,CountryRegionCode
from Person.StateProvince stpro
join Person.Address addr
on
stpro.StateProvinceID=addr.StateProvinceID

--20 - 7 rows
select CRC.CurrencyCode,SUM(SOH.SubTotal+SOH.TaxAmt) As Total
from Sales.SalesOrderHeader SOH
INNER JOIN Sales.SalesTerritory ST ON SOH.TerritoryID = ST.TerritoryID
INNER JOIN Sales.CountryRegionCurrency CRC ON CRC.CountryRegionCode = ST.CountryRegionCode
GROUP BY CurrencyCode