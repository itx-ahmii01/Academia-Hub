create database d_b;
use d_b;
create table Student(
Id int Not Null,
[name] varchar(30),
[email] varchar(30),
password varchar(30),
university_name varchar(30),
vote_count int,
gender char(1),
avator varchar(30),
is_subscribed bit,
primary key (id) 

)
drop table Student
insert into Student values(12,'Akram',123,'FAST',001,'M','***',1)
drop table Student
select *from Subscribe
create table Subscribe(
name varchar(30),
card varchar(30),
password varchar(30),
primary key(card),
Id int Not Null,
foreign key(id) REFERENCES Student(id)
);
drop table Subscribe
create table contact(
name varchar(30),
email varchar(30),
message varchar(300)
)
create table login(
email varchar(30),
password varchar(30)
)
drop table login
select *from contact
create table feed(
email varchar(30),
message varchar(300)
)
drop table feed
select *from feed
select *from login
create procedure [dbo].[Login_Check]
@email varchar(30),
@password varchar(10),
@flag int output
as
begin
	if exists ( select * from Student where  Student.Email = @email and  [Student].[Password] = @password )
	 begin
		set @flag = 1
	 end
	else
	 begin
		set @flag = 0
		print 'Invalid Email or Passward'
	 end
end
GO