CREATE TABLE products (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO products
VALUES
	(1, 'Clean Code'),
	(2, 'Nissan Tirano'),
	(3, 'Google Pixel');

CREATE TABLE categories (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO categories
VALUES
	(1, 'Book'),
	(2, 'Car'),
	(3, 'Gift');

CREATE TABLE productcategories (
	ProductId INT FOREIGN KEY REFERENCES products(Id),
	CategoryId INT FOREIGN KEY REFERENCES categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO productcategories
VALUES
	(1, 1),
	(1, 3),
	(2, 2);

SELECT p.Name, c.Name FROM products p
LEFT JOIN productcategories pc ON p.Id = pc.ProductId
LEFT JOIN categories c ON pc.CategoryId = c.Id;