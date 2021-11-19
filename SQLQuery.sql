DROP TABLE tblUsers
DROP TABLE tblProducts
DROP TABLE tblCart


CREATE TABLE tblUsers
(
	ID int NOT NULL IDENTITY(100000, 1),
	FirstName varchar(50),
	LastName varchar(50),
	Email varchar(150),
	userPassword varchar(150),
	contactNo varchar(25),
	shippingAddress varchar(250),
)

CREATE TABLE tblProducts
(
	ID int NOT NULL IDENTITY(1, 1),
	productName varchar(150),
	productPrice float(50),
	productDescription varchar(150),
	productCategory varchar(50)
)

CREATE TABLE tblCart
(
	userEmail varchar(150),
	productName varchar(150),
	productPrice float(50),
	productAmount int
)

INSERT INTO tblUsers VALUES ('John', 'Smith', 'user@email.com', 'password', '0412345678', 'Fake Street')
INSERT INTO tblUsers VALUES ('Mary', 'Jane', 'admin@email.com', 'password', '0412345678', 'Fake Street')

INSERT INTO tblProducts VALUES ('Commander Legends Booster Pack', 6.00, 'A standard sealed Commander Legends booster pack. Each pack contains 15 cards.', 'Booster Pack')
INSERT INTO tblProducts VALUES ('Magic Origins Booster Pack', 6.00, 'A standard sealed Magic Origins booster pack. Each pack contains 15 cards.', 'Booster Pack')
INSERT INTO tblProducts VALUES ('Strixhaven Booster Pack', 6.00, 'A standard sealed Strixhaven booster pack. Each pack contains 15 cards.', 'Booster Pack')
INSERT INTO tblProducts VALUES ('Theros Beyond Death Booster Box', 175.00, 'A standard sealed Theros Beyond Death booster box. Each booster box contains 36 sealed Theros Beyond Death booster packs.', 'Booster Box')
INSERT INTO tblProducts VALUES ('Throne of Eldraine Booster Box', 175.00, 'A standard sealed Throne of Eldraine booster box. Each booster box contains 36 sealed Throne of Eldraine booster packs.', 'Booster Box')
INSERT INTO tblProducts VALUES ('Commander 2021 - Complete Set', 200.00, 'A complete set of 5 Commander 2021 decks, suitable for the Commander format. Each deck comes complete with 100 ready to play cards.', 'Other')

SELECT * FROM tblUsers
SELECT * FROM tblProducts
SELECT * FROM tblCart