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
