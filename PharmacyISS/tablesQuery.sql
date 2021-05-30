CREATE TABLE Employee
(
	ID INT PRIMARY KEY,
	Surname VARCHAR(40),
	Forename VARCHAR(40) ,
	HireDate DATE,
	WorkingUnit VARCHAR(30) 
);

CREATE TABLE Account
(
	ID INT PRIMARY KEY,
	Email VARCHAR(80),
	Username VARCHAR(40),
	Password VARCHAR(40),
	Employee INT FOREIGN KEY REFERENCES Employee(ID)
);

CREATE TABLE Medicine
(
	ID INT PRIMARY KEY,
	Name VARCHAR(40),
	PackSize INT,
	Quantity INT,
	ExpirationDate DATE
);

CREATE TABLE "Order"
(
	ID INT PRIMARY KEY,
	ETA DATE,
	Destination VARCHAR(40),
	Issuer VARCHAR(40),
	Priority VARCHAR(40),
	DispatchedDate VARCHAR(40),
	Dispatcher VARCHAR(40),
	Status VARCHAR(40),
	ConfirmationDate VARCHAR(40)
);

CREATE TABLE OrderMedicine
(
	ID INT PRIMARY KEY,
	OrderID INT FOREIGN KEY REFERENCES "Order"(ID),
	MedicineID INT FOREIGN KEY REFERENCES Medicine(ID),
	Quantity INT
);