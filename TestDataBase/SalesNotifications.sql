CREATE TABLE [dbo].[Sales]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1,1), 
    [ProductName] NVARCHAR(50) NULL, 
    [Quantity] INT NULL, 
    [SalesNotificationRead] BIT NULL
)
