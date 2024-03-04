GO
USE SchoolMigration

CREATE TABLE Category(
    Id int IDENTITY(1,1),
    CategoryName NVARCHAR(100),
    SubCategoryId int,

    PRIMARY KEY(id)
)

ALTER TABLE Products
    ADD CategoryId int

ALTER TABLE Products
    ADD CONSTRAINT FK_categoryId_category
    FOREIGN KEY (CategoryId) REFERENCES Category(Id)
