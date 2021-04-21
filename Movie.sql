create database movie
go
use movie
go

create table category_movie(
	Id int identity(1,1) primary key not null,
	Name nvarchar(50) not null default N'Phim demo'
)
go

create table movie(
	Id int identity(1,1) primary key not null,
	Name nvarchar(50) not null,
	Movie_length int,
	Movie_release_date date,
	Production_comapany nvarchar(50),
	Status int default 0,--1 sắp chiếu | 0: đang chiếu | 2: Ngừng chiếu
	Category_movie_id int 
	foreign key (Category_movie_id) references category_movie(Id)
)
go

create table cinema_room(
	Id int identity(1,1) primary key not null,
	Name nvarchar(50) not null,
	Quantity_row int not null,
	Quantity_Column int not null,
	Quantity_seat int not null
)
go

alter table cinema_room add RowVip int
alter table cinema_room add ColVip int
alter table cinema_room add RowDoubleSeat int
go

create table category_seat(
	Id int identity(1,1) primary key not null,
	Name nvarchar(50) not null,
	Subcharge int
)
go

alter table category_seat alter column Subcharge float
go

create table seating(
	Id int identity(1,1) primary key not null,
	Position_row varchar(10) not null,
	Position_column int not null,
	Status int,
	Cinema_room_id int not null,
	Category_seat_id int not null,
	foreign key (Cinema_room_id) references cinema_room(Id),
	foreign key (Category_seat_id) references category_seat(Id)
)
go

drop table seating
go

create table format_movie(
	Id int identity(1,1) primary key not null,
	Name nvarchar(100),
	Price float
)
go
create table slot_show(
	Id int identity(1,1) primary key not null,
	Start_time time not null,
	End_time time,
	Day_show date,
	Movie_id int,
	Cinema_room_id int,
	foreign key (Movie_id) references movie(Id),
	foreign key (Cinema_room_id) references cinema_room(Id)
)
go

alter table slot_show add Format_movie_id int
go
alter table slot_show add
foreign key (Format_movie_id) references format_movie(Id)
go

create table price_ticket(
	Id int identity(1,1) primary key not null,
	Name nvarchar(50),
	Price float
)
go

drop table price_ticket
go

create table account(
	Name_user nvarchar(50) primary key not null,
	Name_show nvarchar(50),
	Password nvarchar(50),
	Type int default 0, --:Quản lí | 1:admin | 2:nhân viên bán vé 
)
go



create table ticket_sale(
	Id int identity(1,1) primary key not null,
	Date_sale date,
	Total_price float,
	Slot_show_id int,
	Price_ticket_id int,
	Seat_id int,
	Account_id nvarchar(50),
	foreign key (Slot_show_id) references slot_show(Id),
	foreign key (Price_ticket_id) references price_ticket(Id),
	foreign key (Seat_id) references seating(Id),
	foreign key (Account_id) references account(Name_user)
)
go

alter table ticket_sale add NameSeat nvarchar(10)
go
ALTER TABLE ticket_sale
DROP Constraint FK__ticket_sa__Seat___4CA06362;
ALTER TABLE ticket_sale
DROP Constraint FK__ticket_sa__Price__4BAC3F29;
go
alter table ticket_sale drop column Seat_id
alter table ticket_sale drop column Price_ticket_id
go


select * from ticket_sale
go

create table cate_food(
	Id int identity(1,1) primary key not null,
	Name nvarchar(50)
)
go

create table size_food(
	Id int identity(1,1) primary key not null,
	Name nvarchar(50)
)
go

create table food(
	Id int identity(1,1) primary key not null,
	Name nvarchar(50),
	Status int, -- 0: đang bán | 1: đã bán
	Cate_food_id int,
	foreign key (Cate_food_id) references cate_food(Id)
)
go
create table food_detail(
	Id int identity(1,1) primary key not null,
	Price float,
	Status int, --0: đang bán|1: đã bán
	Foot_id int,
	Size_food_id int,
	foreign key (Foot_id) references food(Id),
	foreign key (Size_food_id) references size_food(Id)
)
go
create table bill_food(
	Id int identity(1,1) primary key not null,
	Date_sale date,
	Account_id nvarchar(50),
	foreign key (Account_id) references account(Name_user)
)
go
create table bill_food_detail(
	Id int identity(1,1) primary key not null,
	Quantity int,
	Total_price float,
	Bill_food_id int,
	Food_detail_id int,
	foreign key (Bill_food_id) references bill_food(Id),
	foreign key (Food_detail_id) references food_detail(Id)
)
go

--Insert Loai ghế
insert into category_seat values
(N'Ghế đôi',30000)
go
-- Insert tài khoản
insert into account values
(N'nthung289',N'nguyen hung',N'123456',0),
(N'user1',N'Nguyen a',N'123456',0)
go

--Thêm mới thể loại phim
insert into category_movie values
(N'Hành động'),
(N'Kinh dị'),
(N'Hài hước'),
(N'Tâm lý'),
(N'Khoa học viễn tưởng')
go



--Thêm mới phòng chiếu
insert into cinema_room values
(N'Phòng 01',10,10,80),
(N'Phòng 02', 10,9,90),
(N'Phòng 03',10,7,70)
go

select * from cinema_room
update cinema_room set RowVip = 2, ColVip = 0 where Id= 3
go


--Thêm loại đồ ăn
insert into cate_food values
(N'Bánh kẹo'),
(N'Đồ ăn nhanh'),
(N'Nước uống')
go

--Thêm size đồ ăn
insert into size_food values
(N'Lớn'),
(N'Trung bình'),
(N'Nhỏ')
go


select * from category_seat
select * from cate_food
select * from food
select * from size_food
select * from bill_food
select * from food_detail
select * from bill_food_detail
select * from seating
select * from movie
select * from cinema_room
select * from account
select * from slot_show
select * from format_movie
select * from ticket_sale

go
delete from slot_show where Id=9
go

select * from movie join cinema_room join slot_show
on slot_show.Cinema_room_id = cinema_room.Id
on slot_show.Movie_id = movie.Id
where movie.Id = 5 and cinema_room.Id = 1 and movie.Status = 0 and movie.Id = 5 and slot_show.Day_show='2021-04-01'
go

insert into ticket_sale values
('2021-04-01',70000,21,null,1,null,N'B-1')
go


select * from ticket_sale,slot_show,format_movie
where ticket_sale.Slot_show_id = slot_show.Id and slot_show.Format_movie_id = format_movie.Id


go


(select hihi.Name, sum(hihi.Format) as 'soluong',hihi.Thang from 
(select format_movie.Name,COUNT(format_movie.Id) as 'Format',Month(slot_show.Day_show) as 'Thang' from ticket_sale,slot_show,format_movie
where ticket_sale.Slot_show_id = slot_show.Id and slot_show.Format_movie_id = format_movie.Id
group by format_movie.Name,slot_show.Day_show) as hihi
group by hihi.Thang,hihi.Name)

go
select *  from format_movie
join slot_show 
on format_movie.Id = slot_show.Format_movie_id
go

select slot_show.Day_show,format_movie.Name , COUNT(format_movie.Name)  from format_movie
join slot_show 
on format_movie.Id = slot_show.Format_movie_id
group by slot_show.Day_show,format_movie.Name
go


select * from ticket_sale
go



select * from movie
select * from slot_show
select * from ticket_sale
go
select movie.Name,movie.Movie_release_date,COUNT(ticket_sale.Id) as 'SoLuongVeBanDuoc',sum(ticket_sale.Total_price) as 'DoanhThu'  from movie,slot_show,ticket_sale
where movie.Id = slot_show.Movie_id and slot_show.Id = ticket_sale.Slot_show_id

group by movie.Name,movie.Movie_release_date
go

update ticket_sale set Account_id = N'nthung289'
go

select * from ticket_sale
select * from bill_food
select * from bill_food_detail
select ticket_sale.Date_sale, sum(ticket_sale.Total_price) as 'totalVe', sum(bill_food_detail.Total_price) as 'totalFood' from account,ticket_sale,bill_food,bill_food_detail
where account.Name_user = ticket_sale.Account_id and account.Name_user = bill_food.Account_id and bill_food.Id = bill_food_detail.Bill_food_id
group by ticket_sale.Date_sale
go


--Tạo proc thống kê đồ ăn
create proc p_tkFoodbyYear
@year int
as
begin
select hihi.Month as 'Month',sum(Total_price) as'Total_price' from
(select Month(Date_sale) as 'Month' ,sum(Total_price) as 'Total_price' from bill_food,bill_food_detail
where bill_food.Id = bill_food_detail.Bill_food_id and YEAR(bill_food.Date_sale) = @year
group by Date_sale) as hihi
group by Month
end
go

exec p_tkFoodbyYear 2021
exec p_tkTicketByYear 2020
go

create proc p_tkTicketByYear
	@year int
as
begin
select hihi.Month,sum(ve) as 've' , sum(totalPrice) as 'totalPrice' from
(select Month(Date_sale) as 'Month',COUNT(Id) as 've',sum(Total_price) as 'totalPrice' from ticket_sale
where YEAR(Date_sale) = @year
group by Date_sale) as hihi
group by Month
end
go


select Date_sale,sum(Total_price) as 'Total_price' from ticket_sale
group by Date_sale
go

select * from ticket_sale
select * from slot_show
select * from format_movie
go
select Month(ticket_sale.Date_sale) as 'Month',format_movie.Name, COUNT(ticket_sale.Id) as 'SoLuongVe' from ticket_sale,slot_show,format_movie
where ticket_sale.Slot_show_id = slot_show.Id and slot_show.Format_movie_id = format_movie.Id
group by ticket_sale.Date_sale,format_movie.Name

go

select hihi.Month,hihi.Name,sum(hihi.SoLuongVe) as 'SoLuongVe' from(
select Month(ticket_sale.Date_sale) as 'Month',format_movie.Name, COUNT(ticket_sale.Id) as 'SoLuongVe' from ticket_sale,slot_show,format_movie
where ticket_sale.Slot_show_id = slot_show.Id and slot_show.Format_movie_id = format_movie.Id
group by ticket_sale.Date_sale,format_movie.Name) as hihi
group by hihi.Month,hihi.Name
go

select Month as 'Thangall',[2D],[3D],[Imax] from(
select hihi.Month,hihi.Name,sum(hihi.SoLuongVe) as 'SoLuongVe' from
(select Month(ticket_sale.Date_sale) as 'Month',format_movie.Name, COUNT(ticket_sale.Id) as 'SoLuongVe' from ticket_sale,slot_show,format_movie
where ticket_sale.Slot_show_id = slot_show.Id and slot_show.Format_movie_id = format_movie.Id
group by ticket_sale.Date_sale,format_movie.Name) as hihi
group by hihi.Month,hihi.Name) as bangnguon
pivot
(
	sum(SoLuongVe) for Name In([2D],[3D],[Imax]) 
)
as bangchuyen
go




select hihi.Month,hihi.Name,sum(hihi.SoLuongVe) as 'SoLuongVe',sum(DoanhThu) as 'Doanhthu' from
(select Month(ticket_sale.Date_sale) as 'Month',format_movie.Name, COUNT(ticket_sale.Id) as 'SoLuongVe',(ticket_sale.Total_price * Count(ticket_sale.Id)) as 'DoanhThu' from ticket_sale,slot_show,format_movie
where ticket_sale.Slot_show_id = slot_show.Id and slot_show.Format_movie_id = format_movie.Id
group by ticket_sale.Date_sale,format_movie.Name,ticket_sale.Total_price) as hihi
group by hihi.Month,hihi.Name
go

select Month as 'Thangall',[2D],[3D],[Imax] 
from(
	select hihi.Month,hihi.Name,sum(hihi.SoLuongVe) as 'SoLuongVe' from(
		select Month(ticket_sale.Date_sale) as 'Month',format_movie.Name, COUNT(ticket_sale.Id) as 'SoLuongVe',(ticket_sale.Total_price* COUNT(ticket_sale.Id)) as 's' from ticket_sale,slot_show,format_movie
		where ticket_sale.Slot_show_id = slot_show.Id and slot_show.Format_movie_id = format_movie.Id
		group by ticket_sale.Date_sale,format_movie.Name) as hihi
		group by hihi.Month,hihi.Name
	) as bangnguon
pivot
(
	sum(SoLuongVe) for Name In([2D],[3D],[Imax]) 
)
as bangchuyen
go

delete from ticket_sale where Id=86
go

select nguon.Month,sum(nguon.SoLuongVe) as'Sl', sum(nguon.Doanhthu) as 'dt'
from (
	select hihi.Month,hihi.Name,sum(hihi.SoLuongVe) as 'SoLuongVe',sum(DoanhThu) as 'Doanhthu' from
	(select Month(ticket_sale.Date_sale) as 'Month',format_movie.Name, COUNT(ticket_sale.Id) as 'SoLuongVe',(ticket_sale.Total_price * Count(ticket_sale.Id)) as 'DoanhThu' from ticket_sale,slot_show,format_movie
	where ticket_sale.Slot_show_id = slot_show.Id and slot_show.Format_movie_id = format_movie.Id
	group by ticket_sale.Date_sale,format_movie.Name,ticket_sale.Total_price) as hihi
	group by hihi.Month,hihi.Name
) as nguon
group by nguon.Month














select Month as 'Thangall',[2D],[3D],[Imax],[4] ,[5] from(
select hihi.Month,hihi.Name,sum(hihi.SoLuongVe) as 'SoLuongVe',sum(DoanhThu) as 'Doanhthu' from
(select Month(ticket_sale.Date_sale) as 'Month',format_movie.Name, COUNT(ticket_sale.Id) as 'SoLuongVe',(ticket_sale.Total_price * Count(ticket_sale.Id)) as 'DoanhThu' from ticket_sale,slot_show,format_movie
where ticket_sale.Slot_show_id = slot_show.Id and slot_show.Format_movie_id = format_movie.Id
group by ticket_sale.Date_sale,format_movie.Name,ticket_sale.Total_price) as hihi
group by hihi.Month,hihi.Name) as bangnguon
pivot
(
	sum(SoLuongVe) for Name In([2D],[3D],[Imax]) 
) as pv1
pivot
(
	sum(Doanhthu) for Month In([4],[5]) 
) 
as bangchuyen
go

select hihi.Month,hihi.Name,sum(hihi.SoLuongVe) as 'SoLuongVe',sum(DoanhThu) as 'Doanhthu' from
(select Month(ticket_sale.Date_sale) as 'Month',format_movie.Name, COUNT(ticket_sale.Id) as 'SoLuongVe',(ticket_sale.Total_price * Count(ticket_sale.Id)) as 'DoanhThu' from ticket_sale,slot_show,format_movie
where ticket_sale.Slot_show_id = slot_show.Id and slot_show.Format_movie_id = format_movie.Id
group by ticket_sale.Date_sale,format_movie.Name,ticket_sale.Total_price) as hihi
group by hihi.Month,hihi.Name
go









