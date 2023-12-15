create database Library2;
GO

use Library2
Go

create table book
(
	bookImage image default 0x443A5C5C50696374757265735C5C666163652E6A7067,
	isbn varchar(30) primary key,
	name nvarchar(50) default N'Không có'  not null,
	author nvarchar(50) default N'Không có' not null,
	genre nvarchar(50) default N'Không có' not null,
	publisher nvarchar(50) default N'Không có' not null,
	publicationDate date default getDate() not null,
	importDate date default getDate() not null,
	pages int default 0 not null,
	copies int default 0 not null,
	description nvarchar(100) default N'' not null
)
Go

create table borrower
(
	id varchar(20) primary key,
	name nvarchar(50) not null default N'Không có',
	class varchar(20) not null default '__',
	phone varchar(20) not null default '__',
	gmail varchar(50) not null default '__'
)
Go

create table borrowBook
(
	id varchar(20),
	isbn varchar(30),
	qty int default 0,
	borrowDate date default GetDate(),
	giveBackDate date default GetDate()

	primary key(id, isbn)
	foreign key (id) references borrower(id), 
	foreign key (isbn) references book(isbn)
)
go

create proc selectAllBook
as
begin
	select  bookImage as N'Ảnh',
			isbn as N'Mã sách',
			name as N'Tên sách',
			author as N'Tác giả',
			genre as N'Thể loại',
			publisher as N'Nhà phát hành',
			publicationDate as N'Ngày phát hành',
			importDate as N'Ngày nhập kho',
			pages as N'Số trang',
			copies as N'Số bản',
			description as N'Mô tả' from book
end
go

create proc addBook
@image image, 
@isbn varchar(30),
@name nvarchar(50),
@author nvarchar(50),
@genre nvarchar(50),
@publisher nvarchar(50),
@publicationDate date,
@importDate date,
@pages int,
@copies int,
@description nvarchar(100)
as
begin
	insert into book values (@image, @isbn, @name, @author, @genre, @publisher, @publicationDate, @importDate, @pages, @copies, @description)
end
Go

create proc delBook
@isbn varchar(30)
as
begin
	delete from book where isbn = @isbn;
end
go

create proc updateBook
@image image, 
@isbn varchar(30),
@name nvarchar(50),
@author nvarchar(50),
@genre nvarchar(50),
@publisher nvarchar(50),
@publicationDate date,
@importDate date,
@pages int,
@copies int,
@description nvarchar(100)
as
begin
	update book
	set bookImage = @image, 
		isbn = @isbn, 
		name = @name, 
		author = @author,
		genre = @genre, 
		publisher = @publisher, 
		publicationDate = @publicationDate, 
		importDate = @importDate, 
		pages = @pages,
		copies = @copies,
		description = @description
	where isbn = @isbn;
end
go

create proc searchBook
@isbn varchar(30),
@name nvarchar(50),
@author nvarchar(50),
@publisher nvarchar(50)
as
begin 
	select * from book where isbn like '%'+@isbn+'%' or name like '%'+@name+'%' or author like '%'+@author+'%' or publisher like '%'+@publisher+'%'
end
go

create proc filterBook
@importDateStart date,
@importDateEnd date,
@pubDateStart date,
@pubDateEnd date,
@copiesStart int,
@copiesEnd int
as
begin
	select * from book
			where importDate >= @importDateStart and importDate <= @importDateEnd or
				  publicationDate >= @pubDateStart and publicationDate <= @pubDateEnd or
				  copies >= @copiesStart and copies <= @copiesEnd
end
go

create proc selectAllBorrower
as
begin
	select borrower.id as N'Mã số',
		   borrower.name as N'Họ và Tên',
		   class as N'Lớp', 
		   book.name as N'Tên sách', 
		   borrowBook.qty as N'Số lượng',
		   borrowDate as N'Ngày mượn',
		   giveBackDate as N'Ngày trả' 
		   from book, borrower, borrowBook  where book.isbn = borrowBook.isbn and borrower.id = borrowBook.id
end	
go

create proc addBorrower
@id varchar(20),
@name nvarchar(50),
@class varchar(20),
@phone varchar(20),
@gmail varchar(50)
as
begin 
	insert into borrower(id, name, class, phone, gmail) values (@id, @name, @class, @phone, @gmail)
end
go

create proc addBorrow
@id varchar(20),
@bookName nvarchar(50),
@qty int,
@borrowDate date,
@giveBackDate date
as
begin 
	declare @tmpIsbn varchar(50) = (select isbn from book where name = @bookName)
	insert into borrowBook values (@id, @tmpIsbn, @qty, @borrowDate, @giveBackDate);
	update book set copies = copies - @qty where isbn = @tmpIsbn;
end
go

create proc searchBorrower
@name nvarchar(50),
@class varchar(20),
@phone varchar(20),
@gmail varchar(50),
@bookName nvarchar(50)
as
begin 
	select borrower.name as N'Họ và Tên', 
		   borrower.class as N'Lớp', 
		   book.name as N'Tên sách', 
		   borrowBook.qty as N'Số lượng', 
		   borrowBook.borrowDate as N'Ngày mượn', 
		   borrowBook.giveBackDate as N'Ngày trả' 
		   from borrowBook
		   inner join book on borrowBook.isbn = book.isbn
		   inner join borrower on borrowBook.id = borrower.id
		   where borrower.name like '%'+@name+'%' or 
				 borrower.class like '%'+@class+'%' or 
				 borrower.phone like '%'+@phone+'%' or
				 borrower.gmail like '%'+@gmail+'%' or
				 book.name like '%'+@bookName+'%'
end
go

create proc giveBackBook
@name nvarchar(50),
@bookName nvarchar(50)
as
begin
	declare @id varchar(20) = (select borrower.id from borrower where borrower.name = @name);
	declare @isbn varchar(20) = (select isbn from book where book.name = @bookName);
	declare @bookQuantity int = (select borrowBook.qty from borrowBook where borrowBook.id = @id  and borrowBook.isbn = @isbn);

	delete from borrowBook 
	where borrowBook.id = @id  and borrowBook.isbn = @isbn;
	
	update book set copies = copies + @bookQuantity where book.name = @bookName;
	if not exists(select borrowBook.id from borrowBook where id = (select borrower.id from borrower where borrower.name = @name))
	begin
		delete from borrower where borrower.name = @name;
	end
end
go



