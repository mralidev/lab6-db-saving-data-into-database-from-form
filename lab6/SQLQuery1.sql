create database lab6
use lab6
create table crudApp(
	name char(250),
	cnic char(250) primary key,
	email char(250),
	contact char(250)

);
select * from crudApp