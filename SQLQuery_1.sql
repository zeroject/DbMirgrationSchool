IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'SchoolMigration')
    BEGIN
        CREATE DATABASE SchoolMigration;
    END
GO
USE SchoolMigration;

CREATE TABLE Products(
    Id INT PRIMARY KEY,
    Name VARCHAR(MAX),
    Price DECIMAL(2,2)
)