ALTER TABLE dbo.Technicians
ADD FirstName nvarchar(50),
MiddleInitial char(10),
LastName nvarchar(50),
HomeAddress nvarchar(50),
PayPercentage numeric(18,2),
SSN nvarchar(50),
FedIDNum nvarchar(50),
PhoneNum nvarchar(50),
EmailAdd nvarchar(50)

UPDATE dbo.Technicians
set PayPercentage=.70
