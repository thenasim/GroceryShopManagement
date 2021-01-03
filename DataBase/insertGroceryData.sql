-- CATEGORY TABLE
INSERT INTO category VALUES('ca-1', 'Fruits and Vegetables', GETDATE())
INSERT INTO category VALUES('ca-2', 'Meat and Fish', GETDATE())
INSERT INTO category VALUES('ca-3', 'Cooking', GETDATE())
INSERT INTO category VALUES('ca-4', 'Beverages', GETDATE())
INSERT INTO category VALUES('ca-5', 'Home and Cleaning', GETDATE())
INSERT INTO category VALUES('ca-6', 'Pest Control', GETDATE())
INSERT INTO category VALUES('ca-7', 'Office Products', GETDATE())
INSERT INTO category VALUES('ca-8', 'Beauty Products', GETDATE())
INSERT INTO category VALUES('ca-9', 'Health Products', GETDATE())
INSERT INTO category VALUES('ca-10', 'Pet Care', GETDATE())
INSERT INTO category VALUES('ca-11', 'Home Appliances', GETDATE())
INSERT INTO category VALUES('ca-12', 'Baby Care', GETDATE())
SELECT * FROM category ORDER BY id;


-- PRODUCTS TABLE
INSERT INTO products VALUES('pr-1', 'Green Apple', 169, 150, 100, GETDATE(), 'ca-1')
INSERT INTO products VALUES('pr-2', 'Malta', 179, 156, 25, GETDATE(), 'ca-1')
INSERT INTO products VALUES('pr-3', 'Orange', 279, 206, 300, GETDATE(), 'ca-1')
INSERT INTO products VALUES('pr-4', 'Amla', 49, 30, 59, GETDATE(), 'ca-1')
INSERT INTO products VALUES('pr-5', 'Red Grapes', 105, 100, 35, GETDATE(), 'ca-1')
INSERT INTO products VALUES('pr-6', 'Bananna Chompa', 59, 55, 25, GETDATE(), 'ca-1')
INSERT INTO products VALUES('pr-7', 'Coconut', 72, 61, 100, GETDATE(), 'ca-1')

INSERT INTO products VALUES('pr-8', 'Beef Bone', 569, 500, 85, GETDATE(), 'ca-2')
INSERT INTO products VALUES('pr-9', 'Boiler Chicken', 219, 180, 120, GETDATE(), 'ca-2')
INSERT INTO products VALUES('pr-10', 'Beef Boneless', 899, 700, 100, GETDATE(), 'ca-2')
INSERT INTO products VALUES('pr-11', 'Catla Fish', 430, 409, 20, GETDATE(), 'ca-2')
INSERT INTO products VALUES('pr-12', 'Rui Fish', 350, 329, 30, GETDATE(), 'ca-2')
INSERT INTO products VALUES('pr-13', 'Puti Fish', 69, 61, 100, GETDATE(), 'ca-2')
INSERT INTO products VALUES('pr-14', 'Coconut', 72, 61, 100, GETDATE(), 'ca-2')

INSERT INTO products VALUES('pr-15', 'Chinigura Rice', 100, 95, 100, GETDATE(), 'ca-3')
INSERT INTO products VALUES('pr-16', 'Miniket Rice Premium', 350, 320, 300, GETDATE(), 'ca-3')
INSERT INTO products VALUES('pr-17', 'Aarong Miniket Rice', 385, 330, 300, GETDATE(), 'ca-3')

INSERT INTO products VALUES('pr-18', 'Shezan Mango Juice', 20, 18, 122, GETDATE(), 'ca-4')
INSERT INTO products VALUES('pr-19', 'Nescafe', 350, 300, 122, GETDATE(), 'ca-4')
INSERT INTO products VALUES('pr-20', 'Cyprina Grape Juice', 350, 310, 122, GETDATE(), 'ca-4')
INSERT INTO products VALUES('pr-21', 'Orange Juice', 150, 120, 122, GETDATE(), 'ca-4')

INSERT INTO products VALUES('pr-22', 'Odonil Natural Air Freshner', 45, 40, 10, GETDATE(), 'ca-5')
INSERT INTO products VALUES('pr-23', 'Bashundhara Kitchen Towel', 114, 98, 100, GETDATE(), 'ca-5')
SELECT * FROM products ORDER BY id;


-- USERS TABLE
INSERT INTO users VALUES ('us-1', GETDATE(), 'Admin');
INSERT INTO users VALUES ('us-2', GETDATE(), 'Employee');
INSERT INTO users VALUES ('us-3', GETDATE(), 'Manager');
SELECT * FROM users ORDER BY id;


-- LOGINS TABLE
INSERT INTO logins VALUES ('lg-1', 'nasimuddin', 'us-1', GETDATE())
INSERT INTO logins VALUES ('lg-2', 'asifahmed', 'us-2', GETDATE())
INSERT INTO logins VALUES ('lg-3', 'shameem', 'us-3', GETDATE())


-- EMPLOYEE TABLE
INSERT INTO employee VALUES ('em-1', 'nasim uddin', 'nasim@gmail.com', 'male',
	'bogra', '1996-2-8', '01790058492', '2010-3-14', 45000, 'us-1', GETDATE());
INSERT INTO employee VALUES ('em-2', 'asif ahmed', 'asif@gmail.com', 'male',
	'dhaka', '1998-5-9', '01790058491', '2019-5-14', 75000, 'us-2', GETDATE());
INSERT INTO employee VALUES ('em-3', 'shameem ahmed', 'shameem@gmail.com', 'male',
	'chittagong', '1998-10-25', '01790058490', '2012-10-14', 80500, 'us-3', GETDATE());