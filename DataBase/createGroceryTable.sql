DROP TABLE logins
DROP TABLE sales
DROP TABLE products
DROP TABLE category
DROP TABLE employee
DROP TABLE users


---------- CREATE TABLES ----------

CREATE TABLE [users] (
  [id] int IDENTITY(1, 1),
  [appid] nvarchar(255) PRIMARY KEY,
  [updated_at] datetime NOT NULL,
  [user_type] nvarchar(255) NOT NULL
)
GO

CREATE TABLE [employee] (
  [id] int IDENTITY(1, 1),
  [appid] nvarchar(255) PRIMARY KEY,
  [full_name] nvarchar(255) NOT NULL,
  [email] nvarchar(255) UNIQUE,
  [gender] nvarchar(255),
  [address] nvarchar(255),
  [birthdate] date,
  [phone] nvarchar(255) UNIQUE,
  [join_date] date,
  [salary] float NOT NULL DEFAULT (0),
  [user_id] nvarchar(255),
  [updated_at] datetime NOT NULL
)
GO

CREATE TABLE [logins] (
  [id] int IDENTITY(1, 1),
  [appid] nvarchar(255) PRIMARY KEY,
  [password] nvarchar(255) NOT NULL,
  [user_id] nvarchar(255),
  [updated_at] datetime NOT NULL
)
GO

CREATE TABLE [products] (
  [id] int IDENTITY(1, 1),
  [appid] nvarchar(255) PRIMARY KEY,
  [title] nvarchar(255) NOT NULL,
  [price] float NOT NULL,
  [purchase_price] float NOT NULL,
  [quantity] float NOT NULL,
  [updated_at] datetime NOT NULL,
  [category_id] nvarchar(255)
)
GO

CREATE TABLE [category] (
  [id] int IDENTITY(1, 1),
  [appid] nvarchar(255) PRIMARY KEY,
  [name] nvarchar(255) NOT NULL,
  [updated_at] datetime NOT NULL
)
GO

CREATE TABLE [sales] (
  [id] int IDENTITY(1, 1),
  [appid] nvarchar(255) PRIMARY KEY,
  [total_price] float NOT NULL,
  [quantity] float NOT NULL,
  [updated_at] datetime NOT NULL,
  [product_id] nvarchar(255)
)
GO

ALTER TABLE [logins] ADD FOREIGN KEY ([user_id]) REFERENCES [users] ([appid])
GO

ALTER TABLE [employee] ADD FOREIGN KEY ([user_id]) REFERENCES [users] ([appid])
GO

ALTER TABLE [sales] ADD FOREIGN KEY ([product_id]) REFERENCES [products] ([appid])
GO

ALTER TABLE [products] ADD FOREIGN KEY ([category_id]) REFERENCES [category] ([appid])
GO