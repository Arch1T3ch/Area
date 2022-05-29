/* 
В базе данных MS SQL Server есть продукты и категории.
Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов.
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории».
Если у продукта нет категорий, то его имя все равно должно выводиться.
*/
 
CREATE TABLE product(
	id INT IDENTITY(1,1)PRIMARY KEY NOT NULL,
	name nvarchar(30) NOT NULL,
	UNIQUE(name)
);

CREATE TABLE category(
	id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	name nvarchar(30) NOT NULL,
	UNIQUE(name)
);

CREATE TABLE product_category (
	category_id INT FOREIGN KEY REFERENCES category(id),
	product_id INT FOREIGN KEY REFERENCES product(id),
	PRIMARY KEY (category_id, product_id)
);

INSERT product (name)
VALUES
('Product1'),
('Product2'),
('Product3'),
('Product4'),
('Product5');

INSERT category (name)
VALUES
('Category1'),
('Category2'),
('Category3'),
('Category4'),
('Category5');

INSERT product_category (name)
VALUES
('Category1'),
('Category2'),
('Category3'),
('Category4'),
('Category5');

SELECT P."Name", C."Name"
FROM Products P
LEFT JOIN ProductCategories PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id; 