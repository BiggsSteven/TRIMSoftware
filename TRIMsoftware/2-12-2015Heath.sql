Alter Table Technicians
ADD Active Bit

Update Technicians
SET Active = True

CREATE TABLE ImportHist
(
FileImport nvarchar(50) NOT NULL,
Date Datetime,
PRIMARY KEY (FileImport)
);