-- Create product_category table
CREATE TABLE product_category (
    id INT IDENTITY(1,1) PRIMARY KEY, -- Unique and auto-generated primary key
    name NVARCHAR(255) NOT NULL -- Name column of type string
);

-- Create product_details table
CREATE TABLE product_details (
    id INT IDENTITY(1,1) PRIMARY KEY, -- Unique and auto-generated primary key
    name NVARCHAR(255) NOT NULL, -- Name column of type string
    price NVARCHAR(255) NOT NULL, -- Price column of type string
    product_category_id INT, -- Reference key to product_category id
    FOREIGN KEY (product_category_id) REFERENCES product_category(id) -- Foreign key constraint
);

INSERT INTO grocery.dbo.product_category
(name)
VALUES('Dairy products'), 
      ('Meat products'),
      ('Toiletries products'),
      ('Vegetables and Fruits');
     
INSERT INTO grocery.dbo.product_details
(name, price, product_category_id)
VALUES('Milk 3%', '10', 1),
	  ('Blue chees', '30', 1),
	  ('Sausage', '36', 2),
	  ('Schnitzel', '40', 2),
	  ('Shampoo', '22', 3),
	  ('Laundary  soap','20', 3),
	  ('Tomatoes 1 kg', '8', 4),
	  ('Apple 1 kg', '12', 4);

     
