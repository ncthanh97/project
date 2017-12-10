create database Manage_Cinema
use Manage_Cinema;

CREATE TABLE Salary
(
  Position NVARCHAR(50) NOT NULL,
  Salary NVARCHAR(20) NOT NULL,
  Work NVARCHAR(500) NOT NULL
  PRIMARY KEY (Position)
);

CREATE TABLE Staffs
(
  IDStaff CHAR(10) NOT NULL,
  FirstName NVARCHAR(100) NOT NULL,
  LastName NVARCHAR(100) NOT NULL,
  Birthday DATE NOT NULL,
  Sex NVARCHAR(6) NOT NULL,
  PlaceOfBirth NVARCHAR(50) NOT NULL,
  Address1 NVARCHAR(100) NOT NULL,
  IdentityNumber CHAR(20) NOT NULL,
  Email NVARCHAR(100) NOT NULL,
  Position NVARCHAR(50) NOT NULL,
  PhoneNumber NVARCHAR(20) NOT NULL,
  PRIMARY KEY (IDStaff),
  FOREIGN KEY (Position) REFERENCES Salary(Position)
);

CREATE TABLE Users
(
  IDUser CHAR(10) NOT NULL,
  FirstName NVARCHAR(100) NOT NULL,
  LastName NVARCHAR(100) NOT NULL,
  Sex NVARCHAR(6) NOT NULL,
  Birthday DATE NOT NULL,
  PhoneNumber CHAR(20) NOT NULL,
  IdentityNumber CHAR(20) NOT NULL,
  Email NVARCHAR(100) NOT NULL,
  PRIMARY KEY (IDUser)
);

CREATE TABLE Movies
(
  IDMovie CHAR(10) NOT NULL,
  Name NVARCHAR(1000) NOT NULL,
  Genres NVARCHAR(1000) NOT NULL,
  Director NVARCHAR(1000) NOT NULL,
  Actor NVARCHAR(1000) NOT NULL,
  Duration NVARCHAR(20) NOT NULL,
  ReleaseDay DATE NOT NULL,
  Languages NVARCHAR(1000) NOT NULL,
  Country NVARCHAR(1000) NOT NULL,
  Rated NVARCHAR(100) NOT NULL,
  PRIMARY KEY (IDMovie)
);

CREATE TABLE Rooms
(
  IDRoom CHAR(10) NOT NULL,
  SeatNumber INT NOT NULL,
  Area VARCHAR(100) NOT NULL,
  Status NVARCHAR(100) NOT NULL,
  PRIMARY KEY (IDRoom)
);

CREATE TABLE Showtimes
(
  IDShowtime CHAR(10) NOT NULL,
  Time1 TIME NOT NULL,
  Day1 DATE NOT NULL,
  TicketNumber INT NOT NULL,
  IDMovie CHAR(10) NOT NULL,
  IDRoom CHAR(10) NOT NULL,
  PRIMARY KEY (IDShowtime),
  FOREIGN KEY (IDMovie) REFERENCES Movies(IDMovie),
  FOREIGN KEY (IDRoom) REFERENCES Rooms(IDRoom)
);

CREATE TABLE TicketType
(
	IDTicket CHAR(10) NOT NULL,
	Condition NVARCHAR(500) NOT NULL,
	Price INT NOT NULL,
	PRIMARY KEY (IDTicket)
);

CREATE TABLE SellTicketList
(
	IDstl INT IDENTITY(1,1),
	IDMovie CHAR(10) NOT NULL,
	NameMovie NVARCHAR(1000) NOT NULL,
	IDRoom CHAR(10) NOT NULL,
	IDShowtime CHAR(10) NOT NULL,
	TicketType CHAR(10) NOT NULL,
	Position CHAR(5) NOT NULL,
	Time1 TIME NOT NULL,
	Day1 DATE NOT NULL,
	PRIMARY KEY (IDstl),
	FOREIGN KEY (IDMovie) REFERENCES Movies(IDMovie),
	FOREIGN KEY (IDRoom) REFERENCES Rooms(IDRoom),
	FOREIGN KEY (IDShowtime) REFERENCES Showtimes(IDShowtime),
	FOREIGN KEY (TicketType) REFERENCES TicketType(IDTicket)
);

CREATE TABLE Account
(
	IDAccount CHAR(20) NOT NULL,
	Pass CHAR(20) NOT NULL,
	IDStaff CHAR(10) NOT NULL,
	Position NVARCHAR(50) NOT NULL,
	PRIMARY KEY (IDAccount),
	FOREIGN KEY (Position) REFERENCES Salary(Position),
	FOREIGN KEY (IDStaff) REFERENCES Staffs(IDStaff)
);


INSERT INTO Account
VALUES ('admin', '123456', 'S002', 'Manager')

INSERT INTO Account
VALUES ('ticketseller', '123456', 'S001', 'Ticket Seller')


INSERT INTO Salary
VALUES ('Ticket Seller', '20000VND/h', 'Sell ticket')

INSERT INTO Salary
VALUES ('Manager', '40000VND/h', 'Manage cinema')


INSERT INTO SellTicketList
VALUES ('M001', 'Justice League', 'R001', 'ST001', 'TT001', 'A5', '07:30:00', '2017/11/22')

INSERT INTO SellTicketList
VALUES ('M001', 'Justice League', 'R001', 'ST001', 'TT001', 'A6', '07:30:00', '2017/11/22')

INSERT INTO SellTicketList
VALUES ('M001', 'Justice League', 'R001', 'ST001', 'TT001', 'B4', '07:30:00', '2017/11/22')

INSERT INTO SellTicketList
VALUES ('M001', 'Justice League', 'R001', 'ST001', 'TT001', 'B5', '07:30:00', '2017/11/22')

INSERT INTO SellTicketList
VALUES ('M001', 'Justice League', 'R001', 'ST001', 'TT001', 'E8', '07:30:00', '2017/11/22')

--List staff
INSERT INTO Staffs
VALUES('S001','Lê','Khánh','11/03/1997','nam','HCM','10/10 đường 8 khu phố 4 phường Bình An Q2','025637258','lk1103@gmail.com','Ticket Seller', '564564564654')

INSERT INTO Staffs
VALUES('S002','Nguyễn','Chí Thành','1/11/1997','nam','Bình Định','10/16 đường 9 khu phố 4 phường Tân Phong Q7','025637257','nct111@gmail.com', 'Manager', '01693176290')


--List Users
INSERT INTO Users
VALUES('U001','Kim','Bum','nam','1988/05/11','0909282845','025637211','kb1506@gmail.com')
INSERT INTO Users
VALUES('U002','Park','Shinhye','nữ','1990/06/10','0909282841','025637212','psh1606@gmail.com')

--Movies
INSERT INTO Movies
VALUES('M001','Justice League','Action','DC Comics','Wonder Women','120 min', '2015/11/20', 'Vietsub','US','9.0')
INSERT INTO Movies
VALUES('M002','Let Fight Ghost','Comedy','KBS','Kim Soo Hyun','120 min', '2015/11/20', 'Vietsub','Korean','8.9')

--Rooms
INSERT INTO Rooms
VALUES('R001','50','100m2','good')
INSERT INTO Rooms
VALUES('R002','50', '120m2', 'good')

--Showtimes
INSERT INTO Showtimes
VALUES('ST001','07:30:00','2017/11/22','50','M001','R001')
INSERT INTO Showtimes
VALUES('ST002','07:30:00','2017/11/22','50','M002','R001')


INSERT INTO TicketType
VALUES('TT001','student','40000')
INSERT INTO TicketType
VALUES('TT002','Adult','65000')
INSERT INTO TicketType
VALUES('TT003','Children','20000')





--Show all staff
CREATE PROC ListStaff
as
begin
	SELECT * FROM Staffs
end
go



--Add a staff
CREATE PROC AddStaff
  @id CHAR(10),
  @firstname NVARCHAR(100),
  @lastname NVARCHAR(100),
  @birthday DATE,
  @sex NVARCHAR(6),
  @placeOfBirth NVARCHAR(50),
  @address1 NVARCHAR(100),
  @identityNumber CHAR(20),
  @email NVARCHAR(100),
  @position NVARCHAR(50),
  @phoneNumber NVARCHAR(20)
as
begin
	INSERT INTO Staffs
	VALUES (@id, @firstname, @lastname, @birthday, @sex, @placeOfBirth, @address1, @identityNumber, @email, @position, @phoneNumber)
end
go

--Delete a staff by id
CREATE PROC DeleteAStaff
@idstaff CHAR(10)
as
begin
	DELETE FROM Staffs WHERE IDStaff=@idstaff
	DELETE FROM Account WHERE IDStaff = @idstaff
end
go

--Edit staff
CREATE PROC EditInfoStaff
@id CHAR(10),
@firstname NVARCHAR(100),
  @lastname NVARCHAR(100),
  @birthday DATE,
  @sex NVARCHAR(6),
  @placeOfBirth NVARCHAR(50),
  @address1 NVARCHAR(100),
  @identityNumber CHAR(20),
  @email NVARCHAR(100),
  @position NVARCHAR(50),
  @phoneNumber NVARCHAR(20)
as
begin
	UPDATE Staffs
	SET FirstName = @firstname, LastName = @lastname, Birthday = @birthday, Sex = @sex, PlaceOfBirth = @placeOfBirth, Address1 = @address1, IdentityNumber = @identityNumber, Email = @email, Position = @position, PhoneNumber = @phoneNumber
	WHERE IDStaff = @id;
end
go

--Find a staff by id
CREATE PROC FindStaffById
@idstaff CHAR(10)
as
begin
	SELECT * FROM Staffs WHERE IDStaff = @idstaff
end
go

--Find a staff by name
CREATE PROC FindStaffByName
@name CHAR(100)
as
begin
	SELECT * FROM Staffs WHERE FirstName = @name
end
go

--Add a user
CREATE PROC AddUser
  @id CHAR(10),
  @firstname NVARCHAR(100),
  @lastname NVARCHAR(100),
  @sex NVARCHAR(3),
  @birthday DATE,
  @phoneNumber CHAR(20),
  @identityNumber CHAR(20),
  @email NVARCHAR(100)
as
begin
	INSERT INTO Users
	VALUES (@id, @firstname, @lastname, @sex, @birthday, @phoneNumber, @identityNumber, @email)
end
go

--Edit info user
CREATE PROC EditUser
  @id CHAR(10),
  @firstname NVARCHAR(100),
  @lastname NVARCHAR(100),
  @sex NVARCHAR(3),
  @birthday DATE,
  @phoneNumber CHAR(20),
  @identityNumber CHAR(20),
  @email NVARCHAR(100)
as
begin
	UPDATE Users
	SET FirstName = @firstname, LastName = @lastname, Sex = @sex, Birthday = @birthday, PhoneNumber = @phoneNumber, IdentityNumber = @identityNumber, Email = @email
	WHERE IDUser = @id
end
go

--Add a movie
CREATE PROC AddMovie
  @id CHAR(10),
  @name NVARCHAR(1000),
  @genres NVARCHAR(1000),
  @director NVARCHAR(1000),
  @actor NVARCHAR(1000),
  @duration NVARCHAR(20),
  @releaseDay DATE,
  @languages NVARCHAR(1000),
  @country NVARCHAR(1000),
  @rated NVARCHAR(100)
as
begin
	INSERT INTO Movies
	VALUES (@id, @name, @genres, @director, @actor, @duration, @releaseDay, @languages, @country, @rated)
end
go

--Edit info movie
CREATE PROC EditMovie
  @id CHAR(10),
  @name NVARCHAR(1000),
  @genres NVARCHAR(1000),
  @director NVARCHAR(1000),
  @actor NVARCHAR(1000),
  @duration NVARCHAR(20),
  @releaseDay DATE,
  @languages NVARCHAR(1000),
  @country NVARCHAR(1000),
  @rated NVARCHAR(100)
as
begin
	UPDATE Movies
	SET Name = @name, Genres = @genres, Director = @director, Actor = @actor, Duration = @duration, ReleaseDay = @releaseDay, Languages = @languages, Country = @country, Rated = @rated
	WHERE IDMovie = @id
end
go


--Show list movie
CREATE PROC ListMovie
as
begin
	SELECT * FROM Movies
end
go
--Delete a movie
CREATE PROC DeleteMovie
@idmovie CHAR(10)
as
begin
	DELETE FROM Movies WHERE IDMovie=@idmovie
	DELETE FROM Showtimes WHERE IDMovie = @idmovie
	DELETE FROM SellTicketList WHERE IDMovie = @idmovie
end
go
--Find movie by id
CREATE PROC FindMovieById
@idmovie CHAR(10)
as
begin
	SELECT * FROM Movies WHERE IDMovie=@idmovie
end
go
--Find movie by name
CREATE PROC FindMovieByName
@name NVARCHAR(100)
as
begin
	SELECT * FROM Movies WHERE Name = @name
end
go
--Show all users
CREATE PROC ListUser
as
begin
	SELECT * FROM Users
end
go
--Find a user by id
CREATE PROC FindUserById
@id CHAR(10)
as
begin
	SELECT * FROM Users WHERE IDUser=@id
end
go
--Find a user by name
CREATE PROC FindUserByName
@name NVARCHAR(50)
as
begin
	SELECT * FROM Users WHERE FirstName=@name
end
go
--Delete a user
CREATE PROC DeleteUser
@id CHAR(10)
as
begin
	DELETE FROM Users WHERE IDUser=@id
end
go
--Show list room
CREATE PROC ListRoom
as
begin
	SELECT * FROM Rooms
end
go
--Add a room
CREATE PROC AddRoom
@id CHAR(10),
@sn INT,
@area VARCHAR(20),
@status NVARCHAR(50)
as
begin
	INSERT INTO Rooms
	VALUES (@id, @sn, @area, @status)
end
go

--Edit info room
CREATE PROC EditRoom
@id CHAR(10),
@sn INT,
@area VARCHAR(20),
@status NVARCHAR(50)
as
begin
	UPDATE Rooms
	SET SeatNumber = @sn, Area = @area, Status = @status
	WHERE IDRoom = @id
end
go

--Find room by id
CREATE PROC FindRoomById
@id CHAR(10)
as
begin
	SELECT * FROM Rooms WHERE IDRoom = @id
end
go
--Delete a room
CREATE PROC DeleteRoom
@id CHAR(10)
as
begin
	DELETE FROM Rooms WHERE IDRoom = @id
	DELETE FROM Showtimes WHERE IDRoom = @id
	DELETE FROM SellTicketList WHERE IDRoom = @id
end
go
--Show all showtime
CREATE PROC ListShowTime
as
begin
	SELECT * FROM Showtimes ORDER BY Time1, Day1
end
go

CREATE PROC SoldTicket
as
begin
	SELECT * FROM Showtimes s, Movies m WHERE s.IDMovie = m.IDMovie
end
go
--Add a showtime
CREATE PROC AddShowTime
@id CHAR(10),
@time TIME,
@day DATE,
@tn INT,
@idm CHAR(10),
@idr CHAR(10)
as
begin
	INSERT INTO Showtimes
	VALUES (@id, @time, @day, @tn, @idm, @idr)
end
go

--Edit info showtime
CREATE PROC EditShow
@id CHAR(10),
@time TIME,
@day DATE,
@tn INT,
@idm CHAR(10),
@idr CHAR(10)
as
begin
	UPDATE Showtimes
	SET Time1 = @time, Day1 = @day, TicketNumber = @tn, IDMovie = @idm, IDRoom = @idr
	WHERE IDShowtime = @id
end
go

--Find showtime
CREATE PROC FindShowTime
@id CHAR(10)
as
begin
	SELECT * FROM Showtimes WHERE IDShowtime = @id
end
go

CREATE PROC FindShowTimeByIDMovie
@idm CHAR(10)
as
begin
	SELECT * FROM Showtimes WHERE IDMovie = @idm
end
go
--Delete showtime
CREATE PROC DeleteShowtime
@id CHAR(10)
as
begin
	DELETE FROM Showtimes WHERE IDShowtime = @id
	DELETE FROM SellTicketList WHERE IDShowtime = @id
end
go
--Show all ticket type
CREATE PROC ListTicketType
as
begin
	SELECT * FROM TicketType
end
go
--Add a ticket type
CREATE PROC AddTicketType
@id CHAR(10),
@cdt NVARCHAR(500),
@price INT
as
begin
	INSERT INTO TicketType
	VALUES (@id, @cdt, @price)
end
go

--Edit info ticket type
CREATE PROC EditTicketType
@id CHAR(10),
@cdt NVARCHAR(500),
@price INT
as
begin
	UPDATE TicketType
	SET Condition = @cdt, Price = @price
	WHERE IDTicket = @id
end
go

--Find ticket type by id
CREATE PROC FindTicketType
@id CHAR(10)
as
begin
	SELECT * FROM TicketType WHERE IDTicket = @id
end
go
--Delete a ticket type
CREATE PROC DeleteTicketType
@id CHAR(10)
as
begin
	DELETE FROM TicketType WHERE IDTicket = @id
end
go 
--Show all ticket was sold
CREATE PROC TicketWasSold
as
begin
	SELECT * FROM SellTicketList
	ORDER BY Time1, Day1
end
go
--Sell ticket
CREATE PROC SellTicket
@idm CHAR(10),
@nMovie NVARCHAR(1000),
@idr CHAR(10),
@ids CHAR(10),
@idt CHAR(10),
@pos CHAR(5),
@time TIME,
@day DATE
as
begin
	INSERT INTO SellTicketList
	VALUES (@idm, @nMovie, @idr, @ids, @idt, @pos, @time, @day)
end
go
--Find ticket was sold by name movie
CREATE PROC FindTWSByNameMovie
@name NVARCHAR(1000)
as
begin
	SELECT * FROM SellTicketList WHERE NameMovie = @name
	ORDER BY Time1, Day1
end
go
--Find ticket was sold by IDMovie
CREATE PROC FindTWSByIdMovie
@id CHAR(10)
as
begin
	SELECT * FROM SellTicketList WHERE IDMovie = @id
	ORDER BY Time1, Day1
end
go
--Find ticket was sold by id room
CREATE PROC FindTWSByIdRoom
@id CHAR(10)
as
begin
	SELECT * FROM SellTicketList WHERE IDRoom = @id
	ORDER BY Time1, Day1
end
go
--Find ticket was sold by id showtime
CREATE PROC FindTWSByIdShowtime
@id CHAR(10)
as
begin
	SELECT * FROM SellTicketList WHERE IDShowtime = @id
	ORDER BY Time1, Day1
end
go
--Delete ticket
CREATE PROC DeleteTicket
@id INT
as
begin
	DELETE FROM SellTicketList WHERE IDstl = @id
end
go
--Get position
CREATE PROC GetPosition
@idShowtime CHAR(10)
as
begin
	SELECT Position FROM SellTicketList WHERE IDShowtime = @idShowtime
end
go

CREATE PROC ListSalary
as
begin
	SELECT * FROM Salary
end
go

CREATE PROC FindSalary
@pos NVARCHAR(50)
as
begin
	SELECT * FROM Salary WHERE Position = @pos
end
go

CREATE PROC DeleteSalary
@pos NVARCHAR(50)
as
begin
	DELETE FROM Salary WHERE Position = @pos
end
go

CREATE PROC EditSalary
@pos NVARCHAR(50),
@salary NVARCHAR(20),
@work NVARCHAR(500)
as
begin 
	UPDATE Salary
	SET Salary = @salary, Work = @work
	WHERE Position = @pos
end
go

CREATE PROC AddSalary
@pos NVARCHAR(50),
@salary NVARCHAR(20),
@work NVARCHAR(500)
as
begin
	INSERT INTO Salary
	VALUES (@pos, @salary, @work)
end
go

CREATE PROC ListAccount
as
begin
	SELECT * FROM Account
end
go

CREATE PROC AddAccount
@id CHAR(20),
@pw CHAR(20),
@ids CHAR(10),
@pos NVARCHAR(50)
as
begin
	INSERT INTO Account
	VALUES (@id, @pw, @ids, @pos)
end
go

CREATE PROC EditAccount
@id CHAR(20),
@pw CHAR(20),
@ids CHAR(10),
@pos NVARCHAR(50)
as
begin
	UPDATE Account
	SET IDAccount = @id, Pass = @pw, IDStaff = @ids, Position = @pos
	WHERE IDStaff = @id
end
go


CREATE PROC FindAccountByIDAccount
@id CHAR(20)
as
begin
	SELECT * FROM Account WHERE IDAccount = @id
end
go

CREATE PROC FindAccountByIDStaff
@ids CHAR(10)
as
begin
	SELECT * FROM Account WHERE IDStaff = @ids
end
go

CREATE PROC FindAccountByPosition
@idp CHAR(20)
as
begin
	SELECT * FROM Account WHERE Position = @idp
end
go

CREATE PROC DeleteAccount
@id CHAR(20)
as
begin
	DELETE FROM Account WHERE IDAccount = @id
end
go

CREATE PROC ChangeAccount
@id CHAR(20),
@pw CHAR(20)
as
begin
	UPDATE Account
	SET Pass = @pw
	WHERE IDAccount = @id
end
go