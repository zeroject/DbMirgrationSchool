USE SchoolMigration;
GO

CREATE TABLE ProductRatings (
    RatingId INT IDENTITY(1,1) PRIMARY KEY,
    ProductId INT,
    RatingValue DECIMAL(3,2),
    RatingDate DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_ProductRatings_Products FOREIGN KEY (ProductId) REFERENCES Products(Id)
);
GO
