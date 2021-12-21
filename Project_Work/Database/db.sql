create database db;
use db;

create table Student(
Id int Not Null,
name varchar(30),
password varchar(30),
university_name varchar(30),
vote_count int,
gender char(1),
avator varchar(30),
is_subscribed bit,
primary key (Id ),
)

create table homepage(
name varchar(30),
vote_count varchar(30),
)

create table feedback(
name varchar(30),
feedback varchar(100),
)

create table questions(
Ques varchar(100),
Qid int not null,
primary key (Qid ),
)



create table answers(
Ans varchar(100),
Qid int not null,
primary key (Qid ),
foreign key (Qid) references questions(Qid),
)


create table Rank(
Qid int not null,
Userid int not null,
primary key(Qid,Userid),
foreign key (Qid) references questions(Qid),
foreign key (Userid) references Student(Id),
)

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



create procedure [dbo].[Signup_Check]

@Fullname varchar(30),
@email varchar(30),
@password varchar(10),
@flag int output
as
begin
	--IF USER ALREADY EXISTS THEN SET FLAG = 0
	if exists ( select * from Student where  [Student].Email = @email)
	 begin	
		set @flag = 0
		print 'Insert Invalid'
	 end
	else
	 begin		
		set @flag = 1

		--INSERT THE NEW USER AND SET FLAG = 1
		INSERT [dbo].Student([name],[Email],[Password],[Id])
		values (@Fullname,@email,@password,@flag)
		declare @UID int
		print 'User Inserted'	
	 end
end
GO